using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ListOfObjects
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "H:\\CSC224\\";
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            System.Console.WriteLine("before showdialog");
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                System.Console.WriteLine("after showdialog");

                string fileName = fileDialog.FileName;
                FileStream fs = null;
                try
                {
                    txtInputFileName.Text = fileName;
                    txtInputFileName.Focus();
                    txtInputFileName.SelectionStart = fileName.Length;
                    txtInputFileName.SelectionLength = 0;

                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader textIn = new StreamReader(fs);

                   // txtOutputArea.Text = "Contents of file \"" + fileName + "\":\r\n==================\r\n";
                    System.Console.WriteLine("Ready to read file \"" + fileName);
                    while (textIn.Peek() != -1)  // not at end of file
                    {
                        string theLine = textIn.ReadLine();
                        System.Console.WriteLine(theLine);

                        string[] data = theLine.Split(',');
                        for (int i = 0; i < data.Length; i++)
                        {
                            data[i] = data[i].Trim();
                        }
                        int year = Convert.ToInt32(data[2]);
                        decimal miles = Convert.ToDecimal(data[3]);
                        decimal price = Convert.ToDecimal(data[4]);
                        Vehicle currentCar = new Vehicle(data[0], data[1], year,
                            miles, price);
                        vehicles.Add(currentCar);
             }
                    DisplayVehicles();
                //    txtOutputArea.Text += "================== end of file\r\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Read Error");
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
        }

        public void DisplayVehicles()
        {
            lstOutputBox.Items.Clear();

            int lineNum = 0;
            foreach(Vehicle vehicle in vehicles)
            {
                lstOutputBox.Items.Add("Car # " + lineNum + ": " + vehicle.GetDisplayText() + "\r\n");
                lineNum++;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddVehicle addVehicleForm = new frmAddVehicle();
            addVehicleForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            addVehicleForm.ControlBox = false;
            addVehicleForm.MaximizeBox = false;
            DialogResult resultFromAddForm = addVehicleForm.ShowDialog();
            if(resultFromAddForm == DialogResult.OK)
            {
                Vehicle vehicle = (Vehicle)addVehicleForm.Tag;
                vehicles.Add(vehicle);
                lstOutputBox.Items.Clear();
                DisplayVehicles();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstOutputBox.SelectedIndex;
            if(index != -1)
            {
                Vehicle vehicle = vehicles[index];
                DialogResult button = MessageBox.Show(
                    "Are you sure you want to delete the " + vehicle.Year + " " + 
                    vehicle.Make + " " + vehicle.Model, "Confirm Deletion of vehicle",
                    MessageBoxButtons.YesNo);
                if(button == DialogResult.Yes)
                {
                    vehicles.Remove(vehicle);
                    DisplayVehicles();
                }
            }

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtInputFileName.Text;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Vehicle vehicle in vehicles)
                    {
                        writer.WriteLine(vehicle.Make + "," + vehicle.Model + "," + vehicle.Year + "," + vehicle.Miles + "," + vehicle.Price);
                    }
                    MessageBox.Show("File " + path.Substring(path.LastIndexOf(@"\") + 1) + " was written to disk", "Save File Success");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "File Write Error");
            }
        }
    }
}
