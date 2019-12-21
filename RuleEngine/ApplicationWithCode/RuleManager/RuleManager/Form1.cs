using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using System.Reflection;
using System.IO;

namespace RuleManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RuleEngine.Engine.RefreshUi += Engine_RefreshUi;
        }

        void Engine_RefreshUi(object sender, EventArgs e)
        {
            KeyValuePair<string, List<string>> pair = (KeyValuePair<string, List<string>>)sender;
            panel1.Invoke(new MethodInvoker(()=>{
            ucError er=new ucError(pair);
            er.Dock=DockStyle.Top;
            panel1.Controls.Add(er);}));
        }

        //C:\Users\Lalit\Desktop\RuleManager\raw_data.json
        private void btnReadDS_Click(object sender, EventArgs e)
        {
            RuleEngine.Engine.ReadDataStream(txtDSPath.Text);
            btnCreateRule.Enabled = true;
            button1.Enabled = true;
        }
        FrmCreateRule ruleGenerator = null;
        private void btnCreateRule_Click(object sender, EventArgs e)
        {
            if (ruleGenerator == null)
            {
                ruleGenerator = new FrmCreateRule();
                ruleGenerator.FormClosed += ruleGenerator_FormClosed;
                ruleGenerator.ShowDialog();
            }
            else ruleGenerator.BringToFront();
        }

        void ruleGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            ruleGenerator = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.RuleEngine.Engine.ReadRules(Directory.GetCurrentDirectory() + @"\Rules.txt");
            Model.RuleEngine.Engine.ValidateAllRules();
        }
    }
}
