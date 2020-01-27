using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

   
        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtFutureVal.Text = String.Empty;
            decimal monthlyInvest = Convert.ToDecimal(txtMonthlyInvest.Text);
            int years = Convert.ToInt32(txtYears.Text);
            decimal yearlyInterest = Convert.ToDecimal(txtInterestRate.Text);
            decimal interestRate = yearlyInterest / 12 /100;
            decimal futureValue = 0m;
            int months = years * 12;

 
            for (int i = 0; i < months; i++)
            {
              futureValue = (futureValue + monthlyInvest) * (1 + interestRate);
            }

            txtFutureVal.Text = futureValue.ToString("c");


        }
    }
}
