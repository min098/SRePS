using System;
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
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void lblPName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
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
                Program.frmEditE.Dispose();
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

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmEmployee) == true)
            {

                Program.frmEmployee.Focus();

            }
            else
            {
                Program.frmEmployee = new frmEmployeeManagement();
                Program.frmEmployee.Show();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();


        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        public Boolean isUserNameExists()
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            conn.Open();
            OleDbDataReader read;
            string my_query = "SELECT * FROM Employees WHERE [E_ID]=?";
            OleDbCommand cmd = new OleDbCommand(my_query, conn);

            cmd.Parameters.AddWithValue("E_ID", txtUserName.Text);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read.HasRows == true)
                {
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        public Boolean isAdminExists()
        {
            int count = 0;
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            conn.Open();
            OleDbDataReader read;
            string my_query = "SELECT * FROM Employees WHERE [E_Position]=?";
            OleDbCommand cmd = new OleDbCommand(my_query, conn);

            cmd.Parameters.AddWithValue("E_Position", "Admin");
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
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string oldID = Program.frmEmployee.employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string oldPosition = Program.frmEmployee.employeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            if (txtUserName.Text == "" || txtName.Text == "" || txtPass.Text == "" || txtConPass.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    string my_query = "UPDATE [Employees] SET [E_ID]=?, [E_Name]=?, [E_Position]=?, [E_Password]=?,  [E_Status]=? WHERE [E_ID]=?";
                    OleDbCommand cmd = new OleDbCommand(my_query, conn);

                    if (txtUserName.Text == oldID)
                    {
                        cmd.Parameters.AddWithValue("E_ID", txtUserName.Text);
                    }
                    else if (isUserNameExists() == true)
                    {
                        MessageBox.Show("Username exists.", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("E_ID", txtUserName.Text);
                    }

                    cmd.Parameters.AddWithValue("E_Name", txtName.Text);
                    if (cmbPosition.SelectedItem.ToString() == oldPosition)
                    {
                        cmd.Parameters.AddWithValue("E_Position", cmbPosition.SelectedItem.ToString());
                    }
                    else if (isAdminExists() == true)
                    {
                        cmd.Parameters.AddWithValue("E_Position", cmbPosition.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Must have at least one admin.", "Error",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txtConPass.Text != "")
                    {
                        if (txtConPass.Text == txtPass.Text)
                        {
                            cmd.Parameters.AddWithValue("E_Password", txtPass.Text);

                        }
                        else
                        {
                            MessageBox.Show("Password mismatch", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    bool isChecked = rdActive.Checked;
                    if (isChecked)
                        cmd.Parameters.AddWithValue("@E_Status", rdActive.Text);
                    else
                        cmd.Parameters.AddWithValue("@E_Status", rdInactive.Text);


                    cmd.Parameters.AddWithValue("E_ID", oldID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee details edited successfully!");
                    Program.frmEmployee.employeesTableAdapter.Fill(Program.frmEmployee.sRePS_DatabaseDataSet.Employees);
                    this.Close();
                    if (cmbPosition.SelectedItem.ToString() != oldPosition)
                    {
                        //Program.curPosition = cmbPosition.SelectedItem.ToString();
                        //OR
                        MessageBox.Show("Please log in to update your position.");

                        Program.frmLogin = new frmLogIn();
                        Program.frmLogin.Show();
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f != Program.frmLogin)
                                f.Close();
                        }

                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    conn.Close();
                }

                
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click_1(object sender, EventArgs e)
        {

        }
    }
}
