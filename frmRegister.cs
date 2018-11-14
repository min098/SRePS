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
    public partial class frmRegister : Form
    {
        string status = "";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sRePS_DatabaseDataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPosistion_Click(object sender, EventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            try
            {
                con.Open();

                if (rdInactive.Checked)
                {
                    status = "Inactive";
                }

                if (rdActive.Checked)
                {
                    status = "Active";
                }

                string data = "Insert into `Employees`(`E_ID`,`E_Name`,`E_Position`,`E_Status`,`E_Password`)VALUES (?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(data, con);
                cmd.Parameters.AddWithValue("@E_ID", e_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@E_Name", e_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@E_Position", cmbPosition.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@E_Status", status);
                cmd.Parameters.AddWithValue("@E_Password", e_PasswordTextBox.Text);

                if (e_PasswordTextBox.Text != e_ConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Register Failed due to Password and Confirm Password mismatch ");
                }
                else if (e_NameTextBox.Text == "")
                {
                    MessageBox.Show("Register Failed due to name is empty ");
                }
                else if (e_IDTextBox.Text == "")
                {
                    MessageBox.Show("Register Failed due to User Name is empty");
                }
                else if (e_PasswordTextBox.Text == "" || e_ConfirmPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Register Failed due to Password or Confirm Password is empty");
                }
                else if (status == "")
                {
                    MessageBox.Show("Register Failed due to status is empty");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Successfully");
                    e_IDTextBox.Text = "";
                    e_NameTextBox.Text = "";
                    e_PasswordTextBox.Text = "";
                    e_ConfirmPasswordTextBox.Text = "";
                    cmbPosition.Items.Clear();
                    rdActive.Checked = false;
                    rdInactive.Checked = false;

                    con.Close();

                    if (Program.isOpened(Program.frmEmployee))
                    {
                        this.Dispose();
                        Program.frmEmployee.employeesTableAdapter.Fill(Program.frmEmployee.sRePS_DatabaseDataSet.Employees);

                    }
                    else
                    {
                        Program.frmLogin = new frmLogIn();
                        Program.frmLogin.Show();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmEmployee) == true)
            {
                this.Close();
                Program.frmEmployee.Focus();

            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
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
                this.Dispose();
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
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

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
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
                Program.frmHome.Dispose();
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
                this.Dispose();
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
                this.Dispose();
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
                this.Dispose();
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
                this.Dispose();
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
                this.Dispose();
            }
        }
    }
}
