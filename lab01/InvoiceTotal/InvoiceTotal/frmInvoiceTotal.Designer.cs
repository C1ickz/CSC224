namespace InvoiceTotal
{
    partial class frmInvoiceTotal
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.subtotalBox = new System.Windows.Forms.TextBox();
            this.discountPercentBox = new System.Windows.Forms.TextBox();
            this.discountAmountBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(54, 168);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(171, 168);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // subtotalBox
            // 
            this.subtotalBox.Location = new System.Drawing.Point(146, 38);
            this.subtotalBox.Name = "subtotalBox";
            this.subtotalBox.Size = new System.Drawing.Size(100, 20);
            this.subtotalBox.TabIndex = 6;
            // 
            // discountPercentBox
            // 
            this.discountPercentBox.Location = new System.Drawing.Point(146, 68);
            this.discountPercentBox.Name = "discountPercentBox";
            this.discountPercentBox.ReadOnly = true;
            this.discountPercentBox.Size = new System.Drawing.Size(100, 20);
            this.discountPercentBox.TabIndex = 7;
            // 
            // discountAmountBox
            // 
            this.discountAmountBox.Location = new System.Drawing.Point(146, 97);
            this.discountAmountBox.Name = "discountAmountBox";
            this.discountAmountBox.ReadOnly = true;
            this.discountAmountBox.Size = new System.Drawing.Size(100, 20);
            this.discountAmountBox.TabIndex = 8;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(146, 126);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 9;
            // 
            // frmInvoiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 232);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.discountAmountBox);
            this.Controls.Add(this.discountPercentBox);
            this.Controls.Add(this.subtotalBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoiceTotal";
            this.Text = "Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox subtotalBox;
        private System.Windows.Forms.TextBox discountPercentBox;
        private System.Windows.Forms.TextBox discountAmountBox;
        private System.Windows.Forms.TextBox totalBox;
    }
}

