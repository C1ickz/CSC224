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

            foreach(string month in months)
            {
                txtInput.AppendText(month + ":\r\n");
            }

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string[] txtContents = txtInput.Text.Split('\n');
            int sales = 0;
            foreach(string line in txtContents)
            {
                if (line.Length != 0)
                {
                    sales = Convert.ToInt32(line.Substring(line.IndexOf(':') + 1));
                    txtOutput.AppendText(line.Substring(0, line.IndexOf(':')));
                    for (int i = 0; i < sales; i++)
                    {
                        txtOutput.AppendText("*");
                    }
                    txtOutput.AppendText($"({sales})\r\n");
                }
            }

        }
    }
}
