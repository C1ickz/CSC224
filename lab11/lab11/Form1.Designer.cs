namespace lab11
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
            this.btnBookTable = new System.Windows.Forms.Button();
            this.btnBookCopiesTable = new System.Windows.Forms.Button();
            this.btnBranchTable = new System.Windows.Forms.Button();
            this.btnAuthorTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book/Author Database Viewer Application";
            // 
            // btnBookTable
            // 
            this.btnBookTable.Location = new System.Drawing.Point(96, 147);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(143, 44);
            this.btnBookTable.TabIndex = 1;
            this.btnBookTable.Text = "View Book Table";
            this.btnBookTable.UseVisualStyleBackColor = true;
            // 
            // btnBookCopiesTable
            // 
            this.btnBookCopiesTable.Location = new System.Drawing.Point(544, 354);
            this.btnBookCopiesTable.Name = "btnBookCopiesTable";
            this.btnBookCopiesTable.Size = new System.Drawing.Size(143, 44);
            this.btnBookCopiesTable.TabIndex = 2;
            this.btnBookCopiesTable.Text = "View BookCopies Table";
            this.btnBookCopiesTable.UseVisualStyleBackColor = true;
            // 
            // btnBranchTable
            // 
            this.btnBranchTable.Location = new System.Drawing.Point(96, 354);
            this.btnBranchTable.Name = "btnBranchTable";
            this.btnBranchTable.Size = new System.Drawing.Size(143, 44);
            this.btnBranchTable.TabIndex = 3;
            this.btnBranchTable.Text = "View Branch Table";
            this.btnBranchTable.UseVisualStyleBackColor = true;
            // 
            // btnAuthorTable
            // 
            this.btnAuthorTable.Location = new System.Drawing.Point(544, 146);
            this.btnAuthorTable.Name = "btnAuthorTable";
            this.btnAuthorTable.Size = new System.Drawing.Size(143, 44);
            this.btnAuthorTable.TabIndex = 4;
            this.btnAuthorTable.Text = "View Author Table";
            this.btnAuthorTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAuthorTable);
            this.Controls.Add(this.btnBranchTable);
            this.Controls.Add(this.btnBookCopiesTable);
            this.Controls.Add(this.btnBookTable);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Book/Author Database Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookTable;
        private System.Windows.Forms.Button btnBookCopiesTable;
        private System.Windows.Forms.Button btnBranchTable;
        private System.Windows.Forms.Button btnAuthorTable;
    }
}

