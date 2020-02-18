using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfObjects
{
    public partial class frmAddVehicle : Form
    {
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year;
            decimal price;
            decimal miles;
            bool yearIsOK = Int32.TryParse(txtYear.Text, out year);
            bool milesAreOK = Decimal.TryParse(txtMiles.Text, out miles);
            bool priceIsOK = Decimal.TryParse(txtPrice.Text, out price);

            if(yearIsOK && milesAreOK && priceIsOK)
            {
                Vehicle vehicle = new Vehicle(make, model, year, miles, price);
                this.Tag = vehicle;

            }
            else
            {
                this.Tag = null;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
