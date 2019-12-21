using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model.RuleReader
{
    public class RuleReader
    {

        string[] Rules = null;

        public string path = @"";

        public string[] ReadRules()
        {
            if (!File.Exists(path))
            {
               FileStream fd= File.Create(path);
               fd.Close();
            }
            
            Rules = File.ReadAllLines(path);

            return Rules;

        }

    }
}
