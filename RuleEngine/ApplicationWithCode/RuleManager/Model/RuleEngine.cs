using Model.DataReader;
using Model.RuleValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class RuleEngine
    {

        static RuleEngine _engine = null;

        public static RuleEngine Engine
        {

            get
            {

                if (_engine == null)

                    _engine = new RuleEngine();

                return _engine;

            }

        }

        public List<string> Signals
        {
            get
            {
                if (stream != null)
                {
                    List<string> lst = new List<string>();
                    foreach (Data d in stream.DataArray)
                    {
                        if(!lst.Contains(d.signal))
                        lst.Add(d.signal);
                    }
                    return lst;
                }
                return null;
            }
        }
        private DataStream stream = null;

        public string[] Rules
        {
            get { return rules; }
        }
        private string[] rules = null;

        List<IRuleValidator> ruleValidators = null;

        private RuleEngine()
        {

        }

        public void ReadDataStream(string path = "")
        {

            DataStreamReader reader = new DataStreamReader();

            if (path != "")

                reader.path = path;

            stream = reader.ReadData();

        }

        public void ReadRules(string path)
        {

            RuleReader.RuleReader reader = new RuleReader.RuleReader();

            if (path != "")

                reader.path = path;

            rules = reader.ReadRules();

        }

        public void ValidateAllRules()
        {

            ruleValidators = new List<IRuleValidator>();

            foreach (string rule in rules)
            {

                IRuleValidator validator = new RuleValidator.RuleValidator();

                validator.Rule = rule;

                validator.SetData(stream.DataArray);

                validator.NotifyWhenComplete += Validator_NotifyWhenComplete;

                validator.ValidateRule();
                ruleValidators.Add(validator);
            }

        }

        public event EventHandler RefreshUi = null;
        Dictionary<string, List<string>> dicErrors = new Dictionary<string, List<string>>();
        object objLock = new object();
        private void Validator_NotifyWhenComplete(object sender, EventArgs e)
        {
            lock (objLock)
            {
                KeyValuePair<string, List<string>> pair = (KeyValuePair<string, List<string>>)sender;
                if (pair.Value != null && pair.Value.Count > 0)
                {
                    if (!dicErrors.ContainsKey(pair.Key))
                    {
                        dicErrors.Add(pair.Key, pair.Value);
                        if (RefreshUi != null)
                            RefreshUi(pair, null);
                    }
                }
            }
        }



    }
}
