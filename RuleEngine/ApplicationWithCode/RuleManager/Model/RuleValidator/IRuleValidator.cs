using Model.DataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.RuleValidator
{
    public interface IRuleValidator
    {

        event EventHandler NotifyWhenComplete;

        string Rule { get; set; }

        Data[] Data { get; }

        bool IsValid { get; }

        validatorStatus Status { get; }

        void ValidateRule();

        void SetData(Data[] dataAr);

    }

    public enum validatorStatus
    {

        NotStarted,

        Started,

        Completed

    }
}
