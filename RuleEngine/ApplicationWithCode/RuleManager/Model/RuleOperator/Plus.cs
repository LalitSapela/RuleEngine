using Model.DataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.RuleOperator
{
    public class Plus : IRuleOperator
    {

        public string OperatorKey { get { return "+"; } }

        private string _operand = "";

        public string Operand
        {

            get { return _operand; }

            set { _operand = value; }

        }

        public bool Validate()
        {
            try
            {
                if (type.ToLower() == "integer")
                {

                    int val = 0;

                    try
                    {
                        if (_data.Contains('.'))
                        { val = Convert.ToInt32(Convert.ToDouble(_data)); }
                        else
                        val = Convert.ToInt32(_data);

                    }

                    catch { return false; }

                    int oper = 0;

                    try
                    {
                        if (_operand.Contains('.'))
                        { oper = Convert.ToInt32(Convert.ToDouble(_operand)); }
                        else
                        oper = Convert.ToInt32(_operand);

                    }

                    catch { return false; }

                    int temp = val + oper;

                    _operator.data = temp.ToString();
                    _operator.datatype = type;
                    return _operator.Validate();

                }

                else if (type.ToLower() == "string")
                {
                    string temp = _data + _operand;

                    _operator.data = temp.ToString();
                    _operator.datatype = type;
                    return _operator.Validate();
                }

                else if (type.ToLower() == "datetime")
                {

                    return false;

                }
            }
            catch { }
            return false;

        }


        private IRuleOperator _operator = null;
        public IRuleOperator Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }

        private string _data = "";
        public string data
        {
            set
            {
                _data = value;
            }
        }

        private string type = "";
        public string datatype
        {
            set
            {
                type=value;
            }
        }
    }
}
