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
            // TODO: This line of code loads data into the 'expDataSet.csc224RyanStates' table. You can move, or remove it, as needed.
            this.csc224RyanStatesTableAdapter.Fill(this.expDataSet.csc224RyanStates);
            // TODO: This line of code loads data into the 'expDataSet.csc224RyanCustomers' table. You can move, or remove it, as needed.
            this.csc224RyanCustomersTableAdapter.Fill(this.expDataSet.csc224RyanCustomers);

        }

    }
}
