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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "H:\\CSC224\\";
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
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

                    int lineNum = 0;
                    txtOutputArea.Text = "Contents of file \"" + fileName + "\":\r\n==================\r\n";
                    while (textIn.Peek() != -1)  // not at end of file
                    {
                        lineNum++;
                        string theLine = textIn.ReadLine();
                        txtOutputArea.Text += theLine + "\r\n";
                    }
                    txtOutputArea.Text += "================== end of file\r\n";
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
    }
}
