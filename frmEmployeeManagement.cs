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

                    if (this.employeeDataGridView.CurrentRow.Cells[3].Value.ToString() == "Female")
                    {
                        Program.frmEditE.rdFemale.Checked = true;
                    }
                    else
                    {
                        Program.frmEditE.rdMale.Checked = true;

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
                    }
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show("No row has been selected. Please select a row to edit", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
