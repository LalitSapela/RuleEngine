using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleManager
{
    public partial class FrmCreateRule : Form
    {
        
        public FrmCreateRule()
        {
            InitializeComponent();
            string dir = Directory.GetCurrentDirectory();
            Model.RuleEngine.Engine.ReadRules(dir + @"\Rules.txt");
            if (Model.RuleEngine.Engine.Rules != null)
            {
                foreach (string s in Model.RuleEngine.Engine.Rules)
                {
                    AddRuleToPanel((object)s);
                }
            }
        }
        
        Rule _rule = null;
        List<string> rules = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if (_rule == null)
            {
                _rule = new Rule();
                _rule.AddRule += _rule_AddRule;
                _rule.FormClosed += _rule_FormClosed;
                _rule.ShowDialog();
            }
            else
                _rule.BringToFront();
        }

        void _rule_FormClosed(object sender, FormClosedEventArgs e)
        {
            _rule = null;
        }

        void _rule_AddRule(object sender, EventArgs e)
        {
            rules.Add(sender as string);
            AddRuleToPanel(sender);
        }
        private void AddRuleToPanel(object sender)
        {
            Label lbl = new Label();
            lbl.Text = sender as string;
            lbl.Dock = DockStyle.Top;
            panel1.Controls.Add(lbl);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\Rules.txt";
            File.AppendAllLines(path, rules);
        }
    }
}
