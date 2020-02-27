namespace Project5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.expDataSet = new Project5.ExpDataSet();
            this.csc224RyanCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csc224RyanCustomersTableAdapter = new Project5.ExpDataSetTableAdapters.csc224RyanCustomersTableAdapter();
            this.tableAdapterManager = new Project5.ExpDataSetTableAdapters.TableAdapterManager();
            this.csc224RyanCustomersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.csc224RyanCustomersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.csc224RyanStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csc224RyanStatesTableAdapter = new Project5.ExpDataSetTableAdapters.csc224RyanStatesTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanCustomersBindingNavigator)).BeginInit();
            this.csc224RyanCustomersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanStatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 80);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 106);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 132);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 158);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 184);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(223, 184);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            zipCodeLabel.TabIndex = 11;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // expDataSet
            // 
            this.expDataSet.DataSetName = "ExpDataSet";
            this.expDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // csc224RyanCustomersBindingSource
            // 
            this.csc224RyanCustomersBindingSource.DataMember = "csc224RyanCustomers";
            this.csc224RyanCustomersBindingSource.DataSource = this.expDataSet;
            // 
            // csc224RyanCustomersTableAdapter
            // 
            this.csc224RyanCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.csc224RyanCustomersTableAdapter = this.csc224RyanCustomersTableAdapter;
            this.tableAdapterManager.csc224RyanStatesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project5.ExpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // csc224RyanCustomersBindingNavigator
            // 
            this.csc224RyanCustomersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.csc224RyanCustomersBindingNavigator.BindingSource = this.csc224RyanCustomersBindingSource;
            this.csc224RyanCustomersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.csc224RyanCustomersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.csc224RyanCustomersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.csc224RyanCustomersBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.csc224RyanCustomersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.csc224RyanCustomersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.csc224RyanCustomersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.csc224RyanCustomersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.csc224RyanCustomersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.csc224RyanCustomersBindingNavigator.Name = "csc224RyanCustomersBindingNavigator";
            this.csc224RyanCustomersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.csc224RyanCustomersBindingNavigator.Size = new System.Drawing.Size(407, 25);
            this.csc224RyanCustomersBindingNavigator.TabIndex = 0;
            this.csc224RyanCustomersBindingNavigator.Text = "bindingNavigator1";
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
            // csc224RyanCustomersBindingNavigatorSaveItem
            // 
            this.csc224RyanCustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.csc224RyanCustomersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("csc224RyanCustomersBindingNavigatorSaveItem.Image")));
            this.csc224RyanCustomersBindingNavigatorSaveItem.Name = "csc224RyanCustomersBindingNavigatorSaveItem";
            this.csc224RyanCustomersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.csc224RyanCustomersBindingNavigatorSaveItem.Text = "Save Data";
            this.csc224RyanCustomersBindingNavigatorSaveItem.Click += new System.EventHandler(this.csc224RyanCustomersBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224RyanCustomersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(86, 77);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224RyanCustomersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(86, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224RyanCustomersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(86, 129);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224RyanCustomersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(86, 155);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224RyanCustomersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(282, 184);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer ID:";
            // 
            // cboStates
            // 
            this.cboStates.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.csc224RyanCustomersBindingSource, "State", true));
            this.cboStates.DataSource = this.csc224RyanStatesBindingSource;
            this.cboStates.DisplayMember = "StateName";
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(86, 184);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(121, 21);
            this.cboStates.TabIndex = 14;
            this.cboStates.ValueMember = "StateCode";
            // 
            // csc224RyanStatesBindingSource
            // 
            this.csc224RyanStatesBindingSource.DataMember = "csc224RyanStates";
            this.csc224RyanStatesBindingSource.DataSource = this.expDataSet;
            // 
            // csc224RyanStatesTableAdapter
            // 
            this.csc224RyanStatesTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 213);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.label1);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.csc224RyanCustomersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanCustomersBindingNavigator)).EndInit();
            this.csc224RyanCustomersBindingNavigator.ResumeLayout(false);
            this.csc224RyanCustomersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csc224RyanStatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExpDataSet expDataSet;
        private System.Windows.Forms.BindingSource csc224RyanCustomersBindingSource;
        private ExpDataSetTableAdapters.csc224RyanCustomersTableAdapter csc224RyanCustomersTableAdapter;
        private ExpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator csc224RyanCustomersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton csc224RyanCustomersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.BindingSource csc224RyanStatesBindingSource;
        private ExpDataSetTableAdapters.csc224RyanStatesTableAdapter csc224RyanStatesTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

