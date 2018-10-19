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
        string gender = "";

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

                if (rdFemale.Checked)
                {
                    gender = "Female";
                }

                if (rdMale.Checked)
                {
                    gender = "Male";
                }

                string data = "Insert into `Employees`(`E_ID`,`E_Name`,`E_Position`,`E_Gender`,`E_Password`)VALUES (?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(data, con);
                cmd.Parameters.AddWithValue("@E_ID", e_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@E_Name", e_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@E_Position", cmbPosition.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@E_Gender", gender);
                cmd.Parameters.AddWithValue("@E_Password", e_PasswordTextBox.Text);

                if (e_PasswordTextBox.Text != e_ConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Register Failed due to Password and Confirm Password mismatch");
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
                    rdMale.Checked = false;
                    rdFemale.Checked = false;

                    con.Close();

                    Program.frmHome = new frmHomepage();
                    Program.frmHome.Show();
                    //temporary
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            e_IDTextBox.Text = "";
            e_NameTextBox.Text = "";
            e_PasswordTextBox.Text = "";
            e_ConfirmPasswordTextBox.Text = "";
            cmbPosition.Items.Clear();
            rdMale.Checked = false;
            rdFemale.Checked = false;

            if (Program.isOpened(Program.frmEmployee))
            {

                this.Dispose();
            }
            else
            {
                Program.frmLogin = new frmLogIn();
                Program.frmLogin.Show();
                //temporary
                this.Dispose();
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
            if (Program.isOpened(Program.frmSales) == true)
            {

                Program.frmSales.Focus();

            }
            else
            {
                Program.frmSales = new frmSalesManagement();
                Program.frmSales.Show();
            }
        }
    }
}
