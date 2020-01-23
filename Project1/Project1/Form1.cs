/******************************
 * CSC 224
 * Programming Assignment # 1
 * Author:  Ryan Harris
 * Date:  January 20, 2020
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

        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            txtOutputArea.Text = String.Empty;
            String clientName = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            int retireAge = Convert.ToInt32(txtRetireAge.Text);
            decimal begginingBal = 0m;
            decimal annualInvest = Convert.ToDecimal(txtAnnInvst.Text);
            decimal interestRate = Convert.ToDecimal(txtIntRate.Text);
            decimal interestEarned = 0m;
            decimal endingBal = annualInvest;
            int year = 2020;

            //Checks if current age is greater than retirement age
            if (age > retireAge)
            {
                txtOutputArea.AppendText("Please check and make sure you set the age to the right number");
            }
            else if (annualInvest == 0)
            {
                txtOutputArea.AppendText("You have to have an annual investment");
            }
            else
            {
                txtOutputArea.AppendText("IRA Summary Projection for " + clientName + "\r\n\r\n");
                txtOutputArea.AppendText("Fixed Annual Investment:  " + annualInvest.ToString("c") + "\t Annual Interest Rate: " + interestRate.ToString("#0.####%") + "\r\n\r\n");

                txtOutputArea.AppendText($"{"Year",10}" +
                                         $"{"Age",10}" +
                                         $"{"Beggining Balance",10}" +
                                         $"{"Annual Investment",10}" +
                                         $"{"Interest Earned",10}" +
                                         $"{"Ending Balance",10}\r\n\r\n\r\n");


                

                for (int i = age; i <= retireAge; i++)
                {

                    txtOutputArea.AppendText($"{year,10}" +
                                             $"{age,10}" +
                                             $"{begginingBal,15:C}" +
                                             $"{annualInvest,15:C}" +
                                             $"{interestEarned,15:C}" +
                                             $"{endingBal,15:C} \r\n");


                    interestEarned = begginingBal * interestRate;
                    endingBal = begginingBal + annualInvest + interestEarned;
                    begginingBal = endingBal;
                    age++;
                    year++;

                }

            }
            
         
            

            
        }

    }
}
