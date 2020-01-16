using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            txtOutputArea.Text = String.Empty;
            String clientName = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            int retireAge = Convert.ToInt32(txtRetireAge.Text);
            decimal annualInvest = Convert.ToDecimal(txtAnnInvst.Text);
            decimal interestRate = Convert.ToDecimal(txtIntRate.Text);
            decimal endingBal = 0m;

            txtOutputArea.AppendText("IRA Summary Projection for " + txtName.Text);
            txtOutputArea.AppendText("Fixed Annual Investment:")

            for(int i = age; i <= retireAge; i++)
            {
                endingBal = calculateIRA(annualInvest, interestRate);
            }


            
        }

        private decimal calculateIRA(decimal annualInvst, decimal intRate)
        {
            decimal endingBal = 0m;
            endingBal = annualInvst * intRate;

            return endingBal;
        }
    }
}
