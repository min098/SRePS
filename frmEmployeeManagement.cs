﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SRePS
{
    public partial class frmEmployeeManagement : Form
    {
        string deleteEID;

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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmRegister) == true)
            {

                Program.frmRegister.Focus();

            }
            else
            {
                Program.frmRegister = new frmRegister();
                Program.frmRegister.Show();
            }
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Employees);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);


        }

        private void frmEmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if this form is the last open form, exit the application
            if (Application.OpenForms.Count == 1)
            {
                //check the close reason so that exit confirmation messagebox only show up for UserClosing, not ApplicationExitCall
                //or else it will pop up two times
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            //prevent "parent" form closed when the "child form" still opened
            else if (Program.isOpened(Program.frmRegister))
            {
                Program.frmRegister.Focus();
                e.Cancel = true;
            }
            else if (Program.isOpened(Program.frmEditE))
            {
                Program.frmEditE.Focus();
                e.Cancel = true;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmLogin) == true)
            {

                Program.frmLogin.Show();
                this.Dispose();

            }
            else
            {
                Program.frmLogin = new frmLogIn();
                Program.frmLogin.Show();
                Program.frmEmployee.Dispose();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmHome) == true)
            {

                Program.frmHome.Focus();

            }
            else
            {
                Program.frmHome = new frmHomepage();
                Program.frmHome.Show();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmProduct) == true)
            {

                Program.frmProduct.Focus();

            }
            else
            {
                Program.frmProduct = new frmProductManagement();
                Program.frmProduct.Show();
            }
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmSalesD) == true)
            {

                Program.frmSalesD.Focus();

            }
            else
            {
                Program.frmSalesD = new frmSalesReportD();
                Program.frmSalesD.Show();
            }
        }

        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmSalesW) == true)
            {

                Program.frmSalesW.Focus();

            }
            else
            {
                Program.frmSalesW = new frmSalesReportW();
                Program.frmSalesW.Show();
            }
        }

        private void monthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmSalesM) == true)
            {

                Program.frmSalesM.Focus();

            }
            else
            {
                Program.frmSalesM = new frmSalesReportM();
                Program.frmSalesM.Show();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
                if (employeeDataGridView.SelectedRows.Count != 0)
                {
                    if (Program.isOpened(Program.frmEditE) == true)
                    {

                        Program.frmEditE.Focus();

                    }
                    else
                    {
                        Program.frmEditE = new frmEditEmployee();
                        Program.frmEditE.Show();
                        Program.frmEditE.txtUserName.Text = this.employeeDataGridView.CurrentRow.Cells[0].Value.ToString();
                        Program.frmEditE.txtUserName.SelectionStart = Program.frmEditE.txtUserName.TextLength;
                        Program.frmEditE.txtName.Text = this.employeeDataGridView.CurrentRow.Cells[1].Value.ToString();
                        if (this.employeeDataGridView.CurrentRow.Cells[2].Value.ToString() == "Admin")
                        {
                            Program.frmEditE.cmbPosition.SelectedItem = "Admin";
                        }
                        else
                        {
                            Program.frmEditE.cmbPosition.SelectedItem = "Cashier";

                        }

                        if (this.employeeDataGridView.CurrentRow.Cells[3].Value.ToString() == "Inactive")
                        {
                            Program.frmEditE.rdInactive.Checked = true;
                        }
                        else
                        {
                            Program.frmEditE.rdActive.Checked = true;

                        }

                        string oldID = Program.frmEmployee.employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                        System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                        conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                        conn.Open();
                        OleDbDataReader read;
                        string my_query = "SELECT * FROM Employees WHERE [E_ID]=?";
                        OleDbCommand cmd = new OleDbCommand(my_query, conn);
                        cmd.Parameters.AddWithValue("E_ID", oldID);

                        read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            Program.frmEditE.txtPass.Text = read["E_Password"].ToString();
                            Program.frmEditE.txtConPass.Text = read["E_Password"].ToString();
                        }
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("No row has been selected. Please select a row to edit.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Only admin can edit employee details. ", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmAddS) == true)
            {

                Program.frmAddS.Focus();

            }
            else
            {
                Program.frmAddS = new frmAddSales();
                Program.frmAddS.Show();
            }
        }

        public Boolean isAdminExists()
        {
            int count = 0;
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            conn.Open();
            OleDbDataReader read;
            string my_query = "SELECT * FROM Employees WHERE [E_Position]=? AND [E_Status]=?";
            OleDbCommand cmd = new OleDbCommand(my_query, conn);

            cmd.Parameters.AddWithValue("E_Position", "Admin");
            cmd.Parameters.AddWithValue("E_Status", "Active");

            read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read.HasRows == true)
                {
                    count++;
                }
            }
            conn.Close();

            if (count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
                if (employeeDataGridView.SelectedRows.Count != 0)
                {
                    int rowIndex = employeeDataGridView.CurrentRow.Index;
                    //Get the deleted row E_ID
                    deleteEID = employeeDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                    DataRow[] foundPID = sRePS_DatabaseDataSet.Sales.Select("E_ID = '" + deleteEID + "'");
                    //Check if the deleting product is existing in the Sales table
                    if (foundPID.Length != 0)
                    {
                        if (isAdminExists() == true)
                        {
                            if (employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString() == "Active")
                            {
                                DialogResult dialogResult = MessageBox.Show("This record cannot be deleted as this employee have made sales before, but you can change the employee's status. Do you want to change the status of this employee?", "Status record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                                    con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;
                                    con.Open();
                                    string query = "UPDATE [Employees] SET [E_Status]=? WHERE [E_ID]=?";
                                    OleDbCommand cmd = new OleDbCommand(query, con);
                                    cmd.Parameters.AddWithValue("E_Status", "Inactive");
                                    cmd.Parameters.AddWithValue("E_ID", deleteEID);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    //update the datagrid
                                    employeesTableAdapter.Fill(sRePS_DatabaseDataSet.Employees);
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString() == "Active")
                            {
                                MessageBox.Show("This record cannot be delete because there is not active admin.", "Status error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("This record has already change the status.", "Status error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        //Pop up confirmation box
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (employeeDataGridView.CurrentRow.Cells[2].Value.ToString() == "Cashier" || (employeeDataGridView.CurrentRow.Cells[2].Value.ToString() == "Admin" && employeeDataGridView.CurrentRow.Cells[3].Value.ToString() == "Inactive"))
                            {
                                this.sRePS_DatabaseDataSet.Employees.Rows[rowIndex].Delete();
                                employeesTableAdapter.Update(sRePS_DatabaseDataSet);
                            }
                            else if (isAdminExists() == true)
                            {
                                this.sRePS_DatabaseDataSet.Employees.Rows[rowIndex].Delete();
                                employeesTableAdapter.Update(sRePS_DatabaseDataSet);
                            }
                            else
                            {
                                MessageBox.Show("This record cannot be delete because there must be at least one active admin.", "Status error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    //if AddSales form is opened, after this changes the AddSales form must be forced to close
                    if (Program.isOpened(Program.frmAddS) == true)
                    {
                        Program.frmAddS.Focus();
                        MessageBox.Show("You have made changes to the Employee table, please reopen the Add Sales window");
                        Program.frmAddS.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No row has been selected. Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Only admin can delete employee account.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < employeeDataGridView.Rows.Count; i++)
            {
                string value = employeeDataGridView.Rows[i].Cells[3].Value.ToString();

                if (value == "Inactive")
                {
                    employeeDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void predictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmPredict) == true)
            {

                Program.frmPredict.Focus();

            }
            else
            {
                Program.frmPredict = new frmPrediction();
                Program.frmPredict.Show();
            }
        }
    }
}
