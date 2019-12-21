using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleManager
{
    public partial class ucError : UserControl
    {
        public ucError(KeyValuePair<string, List<string>> pair)
        {
            InitializeComponent();
            label2.Text = pair.Key;
            StringBuilder sb = new StringBuilder();
            foreach (string s in pair.Value)
            {
                sb.AppendLine(s);
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
