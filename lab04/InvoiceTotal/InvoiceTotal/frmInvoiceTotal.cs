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

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				decimal subtotal = Decimal.Parse(txtSubtotal.Text);
				if(subtotal > 0 && subtotal < 10000)
				{
					decimal discountPercent = .25m;
					decimal discountAmount = subtotal * discountPercent;
					decimal invoiceTotal = subtotal - discountAmount;


					discountAmount = Math.Round(discountAmount, 2);
					invoiceTotal = Math.Round(invoiceTotal, 2);

					txtDiscountPercent.Text = discountPercent.ToString("p1");
					txtDiscountAmount.Text = discountAmount.ToString();
					txtTotal.Text = invoiceTotal.ToString();

					txtSubtotal.Focus();
				}
				else
				{
					MessageBox.Show("Please enter a number between 0 and 10000");
				}
			
	
			}
			catch(FormatException)
			{
				if (txtSubtotal.Text.Trim() == "")
					MessageBox.Show("Cannot leave subtotal empty");

				else
				{
					MessageBox.Show("Format exception... Subtotal must be a decimal value");
				}
			}
			catch (OverflowException)
			{
				MessageBox.Show("Value too large");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace);
			}
	
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}