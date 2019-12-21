using Model.DataReader;
using Model.RuleOperator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Model.RuleValidator
{
    public class RuleValidator : IRuleValidator
    {



        private string rule = "";

        public string Rule
        {

            get { return rule; }

            set { rule = value; PopulateRule(); }

        }

        private bool isvalid = false;

        public bool IsValid { get { return isvalid; } }

        private validatorStatus status = validatorStatus.NotStarted;

        public validatorStatus Status { get { return status; } }



        private string signal = "";

        private Data[] _data = null;

        public Data[] Data
        {

            get { return _data; }

        }



        private IRuleOperator Operator = null;

        private void PopulateRule()
        {
            string[] part = rule.Split(' ');// signal operator oprand operator operand
            signal = part[0];
            if(part.Length>=3)
            setOperator(part[1], ref Operator, part[2]);
            if (part.Length == 5)
            {
                IRuleOperator op = null;
                setOperator(part[3], ref op, part[4]);
                Operator.Operator = op;
            }

        }

        private void setOperator(string operatorKey,ref IRuleOperator oper,string operand)
        {
            switch (operatorKey.ToLower())
            {
                case "contains": oper = new Contains();
                    break;
                case "+": oper = new Plus();
                    break;
                case "==": oper = new Equality();
                    break;
            }
            oper.Operand = operand;
        }
        Thread th = null;



        public event EventHandler NotifyWhenComplete = null;



        public void ValidateRule()
        {

            th = new Thread(() => validate());

            th.Start();

        }
        KeyValuePair<string, List<string>> errors; 
        private void validate()
        {

            status = validatorStatus.Started;
            List<string> er = new List<string>();
            foreach (Data d in _data)
            {
                Operator.data = d.value;
                Operator.datatype = d.value_type;
                if (!Operator.Validate())
                {
                    er.Add("Signal:" + d.signal + ", Value:" + d.value + ", DataType:" + d.value_type);
                    isvalid = false;
                }
            }
            errors = new KeyValuePair<string, List<string>>(rule, er);
            status = validatorStatus.Completed;

            if (NotifyWhenComplete != null)

                NotifyWhenComplete(errors, null);

        }



        public void SetData(Data[] dataArr)
        {

            _data = dataArr.ToList().FindAll(f => f.signal.ToLower() == signal.ToLower()).ToArray();

        }

    }
}
