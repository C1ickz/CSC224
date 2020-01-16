using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(subtotalBox.Text);
            decimal discountPercent = 0m;
            if(subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if( subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if(subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            discountPercentBox.Text = discountPercent.ToString("p1");
            discountAmountBox.Text = discountAmount.ToString("c");
            totalBox.Text = invoiceTotal.ToString("c");
            subtotalBox.Focus();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
