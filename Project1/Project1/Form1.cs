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
            int year = 2020;
            decimal begginingBal = 0m;
            decimal annualInvest = Convert.ToDecimal(txtAnnInvst.Text);
            decimal interestRate = Convert.ToDecimal(txtIntRate.Text);
            decimal interestEarned = 0m;
            decimal endingBal = annualInvest;

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
                txtOutputArea.AppendText("Fixed Annual Investment:  " + annualInvest.ToString("c") + "\t Annual Interest Rate: " + interestRate.ToString("p") + "\r\n\r\n");

<<<<<<< HEAD
                txtOutputArea.AppendText($"{"Year",10}" +
                                         $"{"Age",10}" +
                                         $"{"Beggining Balance",10}" +
                                         $"{"Annual Investment",10}" +
                                         $"{"Interest Earned",10}" +
                                         $"{"Ending Balance",10}\r\n\r\n\r\n");
=======
                //Column names
                //add 10 to the 14 lost from not having "Year" and "Age" on the first line. Total 24 spaces right aligned
                txtOutputArea.AppendText($"{"Beggining",24}{"Annual",14}{"Interest",14}{"Ending",14}\r\n");
                txtOutputArea.AppendText($"{"Year",5}{"Age",5}{"Balance",14}" +
                                         $"{"Investment",14}{"Earned",14}" +
                                         $"{"Balance",14}\r\n");
                txtOutputArea.AppendText($"{"----",5}{"---",5}{"-------",14}" +
                    $"{"----------",14}{"------",14}{"-------",14}\r\n\r\n");
>>>>>>> be1ef7052b1432f5da7d15f612bc376713a79ad4


                decimal totalContribs = 0m, totalInt = 0m;
               
                //fills in data one row at a time
                for (int i = age; i <= retireAge; i++)
                {
                    interestEarned = begginingBal * interestRate;
                    endingBal = begginingBal + annualInvest + interestEarned;
                    txtOutputArea.AppendText($"{year,5}{age,5}{begginingBal,14:C}" +
                                             $"{annualInvest,14:C}{interestEarned,14:C}{endingBal,14:C} \r\n");

                    totalContribs += annualInvest;
                    totalInt += interestEarned;

                
                    begginingBal = endingBal;
                    age++;
                    year++;


                }

                txtOutputArea.AppendText("\r\n \tACCOUNT TOTALS:\t" + totalContribs.ToString("c") + 
                                         "  " + totalInt.ToString("c") + "\r\n");
                txtOutputArea.AppendText("--------- End of Report ---------");



            }





        }

    }
}
