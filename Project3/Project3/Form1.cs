/******************************
 * CSC 224
 * Programming Assignment # 3
 * Author:  Ryan Harris
 * Date:  February 11, 2020
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

namespace Project3
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
                string outputFile = txtInputFile.Text.Substring(0, txtInputFile.Text.LastIndexOf(".")) + ".out";
                txtOutputFile.Text = outputFile;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string path = txtInputFile.Text;


            string[] inputLines = File.ReadAllLines(path);

            string[] dates = new string[inputLines.Count()];
            string[] descriptions = new string[inputLines.Count()];
            decimal[] transactionAmounts = new decimal[inputLines.Count()];
            int[] vendorCodes = new int[inputLines.Count()];
            SortedDictionary<int, decimal> transactionsAtVendors = new SortedDictionary<int, decimal>(); //keeps keys in order from least to greatest
            for (int i = 0; i < inputLines.Count(); i++)
            {
                dates[i] = inputLines[i].Substring(0, 8).Trim();
                descriptions[i] = inputLines[i].Substring(8, 30).Trim();
                transactionAmounts[i] = Convert.ToDecimal(inputLines[i].Substring(38, 10).Trim());

                //add values to dictornary
                if (inputLines[i].Substring(48, 2).Trim().Equals("xx"))
                {

                    vendorCodes[i] = 40;


                    if (transactionsAtVendors.ContainsKey(vendorCodes[i]))
                    {
                        transactionsAtVendors[vendorCodes[i]] += transactionAmounts[i];

                    }
                    else
                    {
                        transactionsAtVendors.Add(40, transactionAmounts[i]);
                    }

                }
                else
                {
                    vendorCodes[i] = Convert.ToInt32(inputLines[i].Substring(48, 2).Trim());
                    if (transactionsAtVendors.ContainsKey(vendorCodes[i]))
                    {
                        transactionsAtVendors[vendorCodes[i]] += transactionAmounts[i];
                    }
                    else
                    {
                        transactionsAtVendors.Add(vendorCodes[i], transactionAmounts[i]);

                    }

                }






            }

            using (StreamWriter sw = new StreamWriter(txtOutputFile.Text))
            {
                sw.WriteLine("CSC 224 - Program # 3");
                sw.WriteLine("Credit Card Account Summary for: Ryan\n");
                sw.WriteLine("     Date    Description" +
                    "                       Amount      Balance");
                sw.WriteLine("   --------  ------------------------------ " +
                    " ----------  ----------");
                sw.WriteLine($"{"Beginning Balance . . . . . . . . . . . . .",56} $");
                decimal balance = 0m;
                for (int i = 0; i < inputLines.Count(); i++)
                {
                    balance += transactionAmounts[i];
                    sw.WriteLine($"   {dates[i],-10}" +
                                 $"{descriptions[i],-30}" +
                                 $"{transactionAmounts[i],12}" +
                                 $"{balance,12}"
                                 );
                }
                sw.WriteLine("   --------  ------------------------------  ----------  ----------");
                if (transactionsAtVendors.ContainsKey(40))
                {
                    sw.WriteLine("\nTotal Purchases from each vendor:        Total Payments:     " + (transactionsAtVendors[40] * -1) + "\n");
                }
                else
                {
                    sw.WriteLine("\nTotal Purchases from each vendor:        Total Payments:     0.00\n");

                }

                sw.WriteLine("   Vendor #  Amount Purchased");
                sw.WriteLine("   --------  ----------------");
                decimal total = 0m;
                foreach (KeyValuePair<int, decimal> kvp in transactionsAtVendors)
                {
                    if (kvp.Key != 40)
                    {
                        sw.WriteLine($"{kvp.Key.ToString(),11}{kvp.Value,18}");
                        total += kvp.Value;
                    }


                }

                sw.WriteLine($"\n{"Total",11}{total,18}");



            }
        }
    }
}