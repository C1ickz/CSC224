/******************************
 * CSC 224
 * Programming Assignment # 5
 * Author:  Ryan Harris
 * Date:  March 3, 2020
 ******************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void csc224RyanCustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.csc224RyanCustomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.csc224RyanStatesTableAdapter.Fill(this.expDataSet.csc224RyanStates);
            cboStates.SelectedIndex = -1;
           // this.csc224RyanCustomersTableAdapter.Fill(this.expDataSet.csc224RyanCustomers);

        }

        private void fillByCustomerIdToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);
                this.csc224RyanCustomersTableAdapter.FillByCustomerId(this.expDataSet.csc224RyanCustomers, customerID);
                if (csc224RyanCustomersBindingSource.Count == 0)
                    MessageBox.Show("No customers are currently in the database taht have this id", "Customer not found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be an int", "Entry Error");
            }

        }

        private void customerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.csc224RyanCustomersBindingSource.CancelEdit();
        }

        private void tsbGetAllCustomers_Click(object sender, EventArgs e)
        {
            this.csc224RyanCustomersTableAdapter.Fill(this.expDataSet.csc224RyanCustomers);
        }

        private void tsbFillByState_Click(object sender, EventArgs e)
        {
      
            string state = txtStateToFill.Text;
            this.csc224RyanStatesTableAdapter.FillByState(this.expDataSet.csc224RyanStates, state);
 
         
        }

       
    }
}
