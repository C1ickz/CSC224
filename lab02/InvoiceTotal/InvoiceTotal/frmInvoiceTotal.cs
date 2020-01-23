using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

		int numberOfInvoices = 0;
		decimal totalOfInvoices = 0m;
		decimal invoiceAvg = 0m;

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtSubtotal.Text, NumberStyles.Currency);		
			decimal discountPercent = .25m;
			decimal discountAmount = Math.Round(subtotal * discountPercent,2);
			decimal invoiceTotal = Math.Round(subtotal - discountAmount,2);
			decimal largest = Decimal.MinValue;
			decimal smallest = Decimal.MaxValue;

			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString();
			txtTotal.Text = invoiceTotal.ToString();

			numberOfInvoices++;
			totalOfInvoices += invoiceTotal;
			invoiceAvg = totalOfInvoices / numberOfInvoices;

			txtNoOfInvoices.Text = numberOfInvoices.ToString();
			txtTotalofInvoices.Text = totalOfInvoices.ToString("c");
			txtInvoiceAvg.Text = invoiceAvg.ToString("c");
			if(smallest < subtotal)
			{
				smallest = subtotal
			}
			else if(largest > subtotal)
			{
				largest = subtotal;
			}

			txtSmallestInvoice.Text = smallest.ToString("c");
			txtLargestInvoice.Text = largest.ToString("c");


			txtSubtotal.Text = String.Empty;

			txtSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClearTotals_Click(object sender, EventArgs e)
		{
			 numberOfInvoices = 0;
			 totalOfInvoices = 0m;
			 invoiceAvg = 0m;

			txtNoOfInvoices.Text = txtInvoiceAvg.Text = txtTotalofInvoices.Text = String.Empty;

			txtSubtotal.Focus();
		}

		private void label11_Click(object sender, EventArgs e)
		{

		}
	}
}