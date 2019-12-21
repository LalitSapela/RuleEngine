using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RuleOperator
{
    public class Equality:IRuleOperator
    {
        public string OperatorKey
        {
            get { return "=="; }
        }
        private string _data=""
;        public string data
        {
            set { _data = value; }
        }
        private string type = "";
        public string datatype
        {
            set { type = value; }
        }
        private string _operand = "";
        public string Operand
        {
            get
            {
                return _operand;
            }
            set
            {
                _operand = value;
            }
        }
        private IRuleOperator _operator = null;
        public IRuleOperator Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }

        public bool Validate()
        {
            if (type.ToLower() == "string")
            {
                return _data.ToLower() == _operand.ToLower();
            }
            else if (type.ToLower() == "integer")
            {
                int val = 0;
                try
                {
                    if (_data.Contains('.'))
                    { val = Convert.ToInt32(Convert.ToDouble(_data)); }
                    else
                    val = Convert.ToInt32(_data); }
                catch { return false; }
                int ope = 0;
                try
                {
                    if (_operand.Contains('.'))
                    { ope = Convert.ToInt32(Convert.ToDouble(_operand)); }
                    else
                    ope = Convert.ToInt32(_operand); }
                catch { return false; }
                return val==ope;
            }
            
            return false;
        }
    }
}
