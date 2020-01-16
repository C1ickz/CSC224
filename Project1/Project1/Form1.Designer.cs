namespace Project1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOutputArea = new System.Windows.Forms.TextBox();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRetireAge = new System.Windows.Forms.TextBox();
            this.txtAnnInvst = new System.Windows.Forms.TextBox();
            this.txtIntRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Planned Retirement Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fixed Annual Investment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest Rate ( as a decimal):\r\n";
            // 
            // txtOutputArea
            // 
            this.txtOutputArea.Location = new System.Drawing.Point(54, 212);
            this.txtOutputArea.Multiline = true;
            this.txtOutputArea.Name = "txtOutputArea";
            this.txtOutputArea.Size = new System.Drawing.Size(600, 226);
            this.txtOutputArea.TabIndex = 5;
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(157, 166);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(242, 23);
            this.btnGenReport.TabIndex = 6;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(339, 29);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtRetireAge
            // 
            this.txtRetireAge.Location = new System.Drawing.Point(616, 29);
            this.txtRetireAge.Name = "txtRetireAge";
            this.txtRetireAge.Size = new System.Drawing.Size(100, 20);
            this.txtRetireAge.TabIndex = 9;
            // 
            // txtAnnInvst
            // 
            this.txtAnnInvst.Location = new System.Drawing.Point(183, 103);
            this.txtAnnInvst.Name = "txtAnnInvst";
            this.txtAnnInvst.Size = new System.Drawing.Size(158, 20);
            this.txtAnnInvst.TabIndex = 10;
            // 
            // txtIntRate
            // 
            this.txtIntRate.Location = new System.Drawing.Point(517, 110);
            this.txtIntRate.Name = "txtIntRate";
            this.txtIntRate.Size = new System.Drawing.Size(114, 20);
            this.txtIntRate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIntRate);
            this.Controls.Add(this.txtAnnInvst);
            this.Controls.Add(this.txtRetireAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.txtOutputArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOutputArea;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRetireAge;
        private System.Windows.Forms.TextBox txtAnnInvst;
        private System.Windows.Forms.TextBox txtIntRate;
    }
}

