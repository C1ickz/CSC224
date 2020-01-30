using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] months = {"January", "February", "March", "April", "May",
  "June", "July", "August", "September", "October", "November", "December"};


        private void btnSetup_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;

            for (int i = 0; i < months.Length;i++)
            {

         
                if (i <= 10)
                {
                    txtInput.AppendText(months[i] + ":\r\n");
                }
                else
                {
                    txtInput.AppendText(months[i] +":");
                }
    
            }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;
            string[] txtContents = txtInput.Text.Split('\n');
            int sales = 0;
            int largest = int.MinValue;
            for (int i = 0; i <txtContents.Length; i++)
            {
               
                sales = Convert.ToInt32(txtContents[i].Substring(txtContents[i].IndexOf(':') + 1));
               if(sales > largest)
                {
                    largest = sales;
                }
                txtOutput.AppendText(months[i]);
                for (int x = 0; x < 9 -months[i].Length; x++)
                {
                    txtOutput.AppendText(" ");
                }
                txtOutput.AppendText("|");
                for (int j = 0; j < sales; j++)
                {
                    txtOutput.AppendText("*");
                }
                txtOutput.AppendText(sales + "\r\n");
            }

            txtOutput.AppendText("         +");
            for(int i = 0; i< largest; i++)
            {
                txtOutput.AppendText("=");
            }
            txtOutput.AppendText("\r\n");
            txtOutput.AppendText("         ");
            int greatestDivisor = divisor(largest); 
            int num = 0;

            
            for (int i = 0; i <= largest / greatestDivisor; i++)
            {
                num = num / 2;
                txtOutput.AppendText(num.ToString());
                for (int j = 0; j < greatestDivisor/2 - 1; j++)
                {
                    txtOutput.AppendText(" ");
                }
                num += greatestDivisor;
            }
 
   
            
        }

        //Code taken from https://stackoverflow.com/questions/3545259/i-need-an-optimal-algorithm-to-find-the-largest-divisor-of-a-number-n-preferabl
        public static int divisor(int number)
        {
            int i;
            for (i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return number / i;
                }
            }
            return 1;
        }
        private void clearInput_Click(object sender, EventArgs e)
        {
            btnSetup_Click(sender, e);

        }
    }
}
       