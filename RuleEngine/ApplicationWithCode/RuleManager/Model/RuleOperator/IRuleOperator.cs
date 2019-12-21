using Model.DataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.RuleOperator
{
    public interface IRuleOperator
    {

        string OperatorKey { get; }

        string data { set; }
        string datatype { set; }

        string Operand { get; set; }

        IRuleOperator Operator { get; set; }
        bool Validate();

    }
}
