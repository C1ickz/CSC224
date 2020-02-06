using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
           
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = fileDialog.FileName;
                string outputFile = txtInputFile.Text.Substring(0, txtInputFile.Text.LastIndexOf(".")) + ".out";
                txtOutputFile.Text = outputFile;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
