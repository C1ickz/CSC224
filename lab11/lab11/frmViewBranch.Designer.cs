namespace lab11
{
    partial class frmViewBranch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBranch));
            System.Windows.Forms.Label branchIDLabel;
            System.Windows.Forms.Label branchNameLabel;
            System.Windows.Forms.Label addressLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.collegeDataSet = new lab11.CollegeDataSet();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchTableAdapter = new lab11.CollegeDataSetTableAdapters.BranchTableAdapter();
            this.tableAdapterManager = new lab11.CollegeDataSetTableAdapters.TableAdapterManager();
            this.branchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.branchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.branchIDTextBox = new System.Windows.Forms.TextBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            branchIDLabel = new System.Windows.Forms.Label();
            branchNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingNavigator)).BeginInit();
            this.branchBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Table";
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "CollegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            this.branchBindingSource.DataSource = this.collegeDataSet;
            // 
            // branchTableAdapter
            // 
            this.branchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookCopiesTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = this.branchTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab11.CollegeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchBindingNavigator
            // 
            this.branchBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.branchBindingNavigator.BindingSource = this.branchBindingSource;
            this.branchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.branchBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.branchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.branchBindingNavigatorSaveItem});
            this.branchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.branchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.branchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.branchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.branchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.branchBindingNavigator.Name = "branchBindingNavigator";
            this.branchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.branchBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.branchBindingNavigator.TabIndex = 2;
            this.branchBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // branchBindingNavigatorSaveItem
            // 
            this.branchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.branchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("branchBindingNavigatorSaveItem.Image")));
            this.branchBindingNavigatorSaveItem.Name = "branchBindingNavigatorSaveItem";
            this.branchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.branchBindingNavigatorSaveItem.Text = "Save Data";
            this.branchBindingNavigatorSaveItem.Click += new System.EventHandler(this.branchBindingNavigatorSaveItem_Click);
            // 
            // branchIDLabel
            // 
            branchIDLabel.AutoSize = true;
            branchIDLabel.Location = new System.Drawing.Point(293, 140);
            branchIDLabel.Name = "branchIDLabel";
            branchIDLabel.Size = new System.Drawing.Size(58, 13);
            branchIDLabel.TabIndex = 2;
            branchIDLabel.Text = "Branch ID:";
            // 
            // branchIDTextBox
            // 
            this.branchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "BranchID", true));
            this.branchIDTextBox.Location = new System.Drawing.Point(374, 137);
            this.branchIDTextBox.Name = "branchIDTextBox";
            this.branchIDTextBox.Size = new System.Drawing.Size(147, 20);
            this.branchIDTextBox.TabIndex = 3;
            // 
            // branchNameLabel
            // 
            branchNameLabel.AutoSize = true;
            branchNameLabel.Location = new System.Drawing.Point(293, 166);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new System.Drawing.Size(75, 13);
            branchNameLabel.TabIndex = 4;
            branchNameLabel.Text = "Branch Name:";
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "BranchName", true));
            this.branchNameTextBox.Location = new System.Drawing.Point(374, 163);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.branchNameTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(293, 192);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(374, 189);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(147, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // frmViewBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(branchIDLabel);
            this.Controls.Add(this.branchIDTextBox);
            this.Controls.Add(branchNameLabel);
            this.Controls.Add(this.branchNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.branchBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "frmViewBranch";
            this.Text = "frmViewBranch";
            this.Load += new System.EventHandler(this.frmViewBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingNavigator)).EndInit();
            this.branchBindingNavigator.ResumeLayout(false);
            this.branchBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CollegeDataSet collegeDataSet;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private CollegeDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private CollegeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator branchBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton branchBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox branchIDTextBox;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}