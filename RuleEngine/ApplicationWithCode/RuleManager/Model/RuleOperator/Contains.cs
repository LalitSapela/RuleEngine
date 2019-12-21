using Model.DataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.RuleOperator
{
    public class Contains : IRuleOperator
    {

        string key = "Contains";



        public string OperatorKey { get { return key; } }
        private string _operand = "";

        public string Operand
        {

            get { return _operand; }

            set { _operand = value; }

        }

        public bool Validate()
        {
            if (type.ToLower() == "string")
            {
                return _data.ToLower().Contains(_operand.ToLower());
            }
            return false;

        }



        private IRuleOperator _operator = null;
        public IRuleOperator Operator
        {
            get { return _operator; }
            set { _operator = value; }
        }

        string _data = "";
        public string data
        {
            set
            {
                _data = value;
            }
        }

        string type = "";
        public string datatype
        {
            set
            {
                type = value;
            }
        }
    }
}
