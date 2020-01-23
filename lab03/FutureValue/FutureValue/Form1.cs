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
            decimal interestRate = Convert.ToDecimal(txtInterestRate.Text);
            decimal futureValue = 0m;
            decimal yearlyInvest = monthlyInvest * 12;
            decimal begginingBalance = 0m;
            decimal interestEarned = 0m;

 
            for (int i = 0; i <= years; i++)
            {
                interestEarned = yearlyInvest * interestRate;
                futureValue = begginingBalance + yearlyInvest + interestEarned;
            }

            txtFutureVal.Text = futureValue.ToString("c");


        }
    }
}
