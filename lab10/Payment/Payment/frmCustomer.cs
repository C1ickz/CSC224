using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        bool isDataSaved = true;

   

        private void dataChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if(selectedButton == DialogResult.OK)
            {
                lblPayment.Text = (string)paymentForm.Tag;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                saveData();
            }
        }

        private void saveData()
        {
            cboNames.SelectedIndex = -1;
            lblPayment.Text = String.Empty;
            isDataSaved = true;
            cboNames.Focus();
        }

        private bool isValidData()
        {
            if(cboNames.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer", "Entry Error ");
                cboNames.Focus();
                return false;
            }
            if(lblPayment.Text == String.Empty)
            {
                MessageBox.Show("You must enter a payment.", "Entry Error");
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(isDataSaved == false)
            {
                string message =
                    "This form contains unsaved data.\n\n" +
                    "Do you want to save it?";

                DialogResult button =
                    MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if(button == DialogResult.Yes)
                {
                    if (isValidData())
                        this.saveData();
                    else
                        e.Cancel = true;        
                }
                if(button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboNames.Items.Add("Example person 1");
            cboNames.Items.Add("Example person 2");
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }
    }
}