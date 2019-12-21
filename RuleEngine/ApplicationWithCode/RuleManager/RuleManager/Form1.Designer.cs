namespace RuleManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDSPath = new System.Windows.Forms.TextBox();
            this.btnReadDS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data stream path";
            // 
            // txtDSPath
            // 
            this.txtDSPath.Location = new System.Drawing.Point(106, 19);
            this.txtDSPath.Name = "txtDSPath";
            this.txtDSPath.Size = new System.Drawing.Size(446, 20);
            this.txtDSPath.TabIndex = 1;
            // 
            // btnReadDS
            // 
            this.btnReadDS.Location = new System.Drawing.Point(13, 54);
            this.btnReadDS.Name = "btnReadDS";
            this.btnReadDS.Size = new System.Drawing.Size(103, 31);
            this.btnReadDS.TabIndex = 2;
            this.btnReadDS.Text = "Read data stream";
            this.btnReadDS.UseVisualStyleBackColor = true;
            this.btnReadDS.Click += new System.EventHandler(this.btnReadDS_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 238);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(429, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Perform rules on data stream";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateRule
            // 
            this.btnCreateRule.Enabled = false;
            this.btnCreateRule.Location = new System.Drawing.Point(218, 54);
            this.btnCreateRule.Name = "btnCreateRule";
            this.btnCreateRule.Size = new System.Drawing.Size(103, 31);
            this.btnCreateRule.TabIndex = 3;
            this.btnCreateRule.Text = "Rule generator";
            this.btnCreateRule.UseVisualStyleBackColor = true;
            this.btnCreateRule.Click += new System.EventHandler(this.btnCreateRule_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateRule);
            this.Controls.Add(this.btnReadDS);
            this.Controls.Add(this.txtDSPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rule Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDSPath;
        private System.Windows.Forms.Button btnReadDS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateRule;
    }
}

