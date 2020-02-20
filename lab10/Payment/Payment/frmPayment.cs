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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private bool isVaidData()
        {
            if (rdoCreditCard.Checked)
            {
                if(lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card", "Entry Error");
                    lstCreditCardType.Focus();
                    return false;
                }

                if(txtCardNumber.Text = "")
                {
                    MessageBox.Show("You must enter a card number", "Entry error");
                    txtCardNumber.Focus();
                    return false;
                }
            }
        }
    }
}
