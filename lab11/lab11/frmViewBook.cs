﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class frmViewBook : Form
    {
        public frmViewBook()
        {
            InitializeComponent();
        }

        private void fromViewBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.collegeDataSet.Book);

        }
    }
}
