﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRePS
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Employees);

        }
    }
}
