using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            DateTime currentDate = DateTime.Parse(txtBirthDate.Text);
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
            int dueDays = (futureDate - currentDate).Days;

            // TODO: Add code to calculate the days until due date
            MessageBox.Show("Current date: \t" + txtBirthDate.Text + "\n\n\n "  +
             "Future Date: \t"  +  txtFutureDate.Text  + "\n\n\n" +
             "Days until due: \t" + dueDays);
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            DateTime currentDate = DateTime.Parse(txtBirthDate.Text);
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
            int dueDays = (futureDate - currentDate).Days;
            dueDays = dueDays / 365;

            // TODO: Add code to calculate the days until due date
            MessageBox.Show("Current date: \t" + txtFutureDate.Text + "\n\n\n " +
             "Birth Date: \t" + txtBirthDate.Text + "\n\n\n" +
             "Age: \t" + dueDays);

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}