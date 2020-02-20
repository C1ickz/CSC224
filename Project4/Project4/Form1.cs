/******************************
 * CSC 224
 * Programming Assignment # 4
 * Author:  Ryan Harris
 * Date:  February 20, 2020
 ******************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = fileDialog.FileName;
    
            }
            string path = txtInputFile.Text;
            string currentState = "";
            string firstName = "";
            string lastName = "";
            string previousState = "";
            decimal customerTotal = 0m;
            decimal stateSubtotal = 0m;
            int customersInState = 0;
            int customersInAllStates = 0;
            decimal total = 0m;

            txtOutput.AppendText("CSC 224 - Program # 4\r\n");
            txtOutput.AppendText("Written by:  Ryan\r\n\r\n");
            try
            {
    
                using (StreamReader sr = new StreamReader(path))
                {
              
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
               
                        currentState = line.Split(';')[0];
                        firstName = (line.Split(';')[1]).Split(',')[1];
                        lastName = (line.Split(';')[1]).Split(',')[0];

                        customerTotal = Convert.ToDecimal(line.Split(';')[2]);

                        if(customersInAllStates == 0)
                        {
                            txtOutput.AppendText("Customers from " + currentState + ":\r\n");
                            previousState = currentState;

                        }


                        if (!currentState.Equals(previousState))
                        {
                            txtOutput.AppendText("\r\n");
                            txtOutput.AppendText("\t Number of customers from " + previousState + ": " + customersInState + 
                                "    (total due from " + previousState + " customers: " + stateSubtotal.ToString("c") +")\r\n");
                            txtOutput.AppendText("\r\nCustomers from " + currentState + ":\r\n");
                            stateSubtotal = customersInState= 0;
                            stateSubtotal = 0m;
                        }
                        txtOutput.AppendText("\t" + firstName + " " + lastName + " (balance due = " + customerTotal.ToString("c") + ")\r\n");

                        customersInState++;
                        customersInAllStates++;
                        stateSubtotal += customerTotal;
                        previousState = currentState;
                        total += customerTotal;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("File formatted incorrectly", "File format error");
            }
            finally
            {
                txtOutput.AppendText("\r\n");
                txtOutput.AppendText("\t Number of customers from " + previousState + ": " + customersInState +
                    "    (total due from " + previousState + " customers: " + stateSubtotal.ToString("c") + ")\r\n");
                txtOutput.AppendText("\r\nTotal Customers from all states: " + customersInAllStates + "\r\n\r\n");
                txtOutput.AppendText("\t Total Due from ALL customers: " + total.ToString("c"));

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string outputFile = txtInputFile.Text.Substring(0, txtInputFile.Text.LastIndexOf(".")) + ".out";
            try
            {
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    sw.WriteLine(txtOutput.Text);
                    MessageBox.Show("File succesfully saved", "File save confirmation");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error when attempting to save the file", "File save error");
            }
        }
    }
}
