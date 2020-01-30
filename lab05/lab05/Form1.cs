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

namespace lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearFileName_Click(object sender, EventArgs e)
        {
            txtFileName.Text = String.Empty;
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;
            FileStream fs = null;
            try
            {

               fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                txtOutput.Text = "Contents of file \"" + filePath + "\":\r\n==================\r\n";
                string theLine;
                int lines = 0;
                int emptyLines = 0;
                while(textIn.Peek() != -1)
                {
                    theLine = textIn.ReadLine();
                    if(theLine == String.Empty)
                    {
                        emptyLines++;
                    }
                    else
                    {
                        txtOutput.AppendText(theLine + "\r\n");
                        lines++;
                    }
                }
                txtOutput.AppendText("================== end of file\r\n");
                txtOutput.AppendText("There are " + lines + " lines with text and there are " + emptyLines + " empty lines");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n File Reading error");
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
