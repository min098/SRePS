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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sRePS_DatabaseDataSet);

        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.sRePS_DatabaseDataSet.Product);
            this.ResetText();
        }

        private void p_SupplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void p_PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void p_PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void p_QuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void lblPCost_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;
            //Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\ASUS\Desktop\SRePS\SRePS_Database.mdb
            try
            {
                conn.Open();

                string my_query = "INSERT INTO `Product` (`P_ID`,`P_Name`,`P_Quantity`,`P_Price`,`P_Cost`,`P_Supplier`,`P_UOM`,`P_Group`) VALUES (?,?,?,?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.Parameters.AddWithValue("@P_ID", Convert.ToInt32(p_IDTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Name", p_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@P_Quantity", Convert.ToInt32(p_QuantityTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Price", Convert.ToDouble(p_PriceTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Cost", Convert.ToDouble(p_CostTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Supplier", p_SupplierTextBox.Text);
                cmd.Parameters.AddWithValue("@P_UOM", p_UOMComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P_Group", p_GroupComboBox.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product due to " + ex.Message);
            }
            finally
            {
                conn.Close();

                foreach (var item in this.Controls)
                {
                    //check item is textbox
                    if (item.GetType().Equals(typeof(TextBox)))
                    {
                        //clear all textbox at the same time
                        TextBox t1 = item as TextBox;
                        t1.Text = string.Empty;
                    }
                }

                foreach (var item in this.Controls)
                {
                    //check item is combobox
                    if (item.GetType().Equals(typeof(ComboBox)))
                    {
                        //clear all combobox at the same time
                        ComboBox c1 = item as ComboBox;
                        c1.Text = string.Empty;
                    }
                }
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel to add this product? (The entered data will be cleared.)", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (var item in this.Controls)
                {
                    //check item is textbox
                    if (item.GetType().Equals(typeof(TextBox)))
                    {
                        //clear all textbox at the same time
                        TextBox t1 = item as TextBox;
                        t1.Text = string.Empty;
                    }
                }

                foreach (var item in this.Controls)
                {
                    //check item is combobox
                    if (item.GetType().Equals(typeof(ComboBox)))
                    {
                        //clear all combobox at the same time
                        ComboBox c1 = item as ComboBox;
                        c1.Text = string.Empty;
                    }
                }

                if (Program.isOpened(Program.frmAddP) == true)
                {

                    Program.frmAddP.Focus();
                }
                else
                {
                    Program.frmAddP = new frmAddProduct();
                    Program.frmAddP.Show();
                }


            }
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
     
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
                Program.frmAddP.Dispose();

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

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
