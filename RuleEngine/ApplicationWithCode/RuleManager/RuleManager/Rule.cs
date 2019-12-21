using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuleManager
{
    public partial class Rule : Form
    {
        public event EventHandler AddRule = null;
        public Rule()
        {
            InitializeComponent();
            comboBox1.DataSource = Model.RuleEngine.Engine.Signals; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rule=(string)comboBox1.SelectedItem+" "+textBox1.Text;
            if (AddRule != null)
            {
                AddRule((object)rule, null);
            }
            this.Close();
        }
    }
}
