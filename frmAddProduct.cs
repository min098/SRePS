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
            p_SubGroupComboBox.Enabled = false;
            p_GroupComboBox.Text = "--Select the main group of product--";
            p_SubGroupComboBox.Text = "--Select the sub group of product--";
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
            Boolean added = false;
            try
            {
                conn.Open();

                string my_query = "INSERT INTO `Product` (`P_ID`,`P_Name`,`P_Quantity`,`P_Price`,`P_Cost`,`P_Supplier`,`P_UOM`,`P_Group`, `P_SubGroup`) VALUES (?,?,?,?,?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.Parameters.AddWithValue("@P_ID", Convert.ToInt32(p_IDTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Name", p_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@P_Quantity", Convert.ToInt32(p_QuantityTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Price", Convert.ToDouble(p_PriceTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Cost", Convert.ToDouble(p_CostTextBox.Text));
                cmd.Parameters.AddWithValue("@P_Supplier", p_SupplierTextBox.Text);
                cmd.Parameters.AddWithValue("@P_UOM", p_UOMComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P_Group", p_GroupComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@P_SubGroup", p_GroupComboBox.SelectedItem.ToString());

                //The selling price must not lower than cost
                if (Convert.ToDouble(p_PriceTextBox.Text) < Convert.ToDouble(p_CostTextBox.Text))
                {
                    MessageBox.Show("Selling price must not be lower than cost!");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                    added = true;
                }

                Program.frmProduct.productTableAdapter.Fill(Program.frmProduct.sRePS_DatabaseDataSet.Product);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product due to " + ex.Message);
            }
            finally
            {
                conn.Close();

                if (added == true)
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

        private void p_GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p_GroupComboBox.SelectedItem.ToString() == "Medicine")
            {
                p_SubGroupComboBox.Enabled = true;
                p_SubGroupComboBox.Items.Clear();
                p_SubGroupComboBox.Items.Add("Allergic");
                p_SubGroupComboBox.Items.Add("Birth Control");
                p_SubGroupComboBox.Items.Add("Central Nervous System");
                p_SubGroupComboBox.Items.Add("Circulatory System");
                p_SubGroupComboBox.Items.Add("Cough");
                p_SubGroupComboBox.Items.Add("Digestive System");
                p_SubGroupComboBox.Items.Add("Ear");
                p_SubGroupComboBox.Items.Add("Eye");
                p_SubGroupComboBox.Items.Add("Endocrine System");
                p_SubGroupComboBox.Items.Add("Fever");
                p_SubGroupComboBox.Items.Add("Immune System");
                p_SubGroupComboBox.Items.Add("Menstrual Pain");
                p_SubGroupComboBox.Items.Add("Musculoskeletal Disorders");
                p_SubGroupComboBox.Items.Add("Nose");
                p_SubGroupComboBox.Items.Add("Pain and Consciousness");
                p_SubGroupComboBox.Items.Add("Reproductive System");
                p_SubGroupComboBox.Items.Add("Respiratory System");
                p_SubGroupComboBox.Items.Add("Throat");
                p_SubGroupComboBox.Items.Add("Skin");
                p_SubGroupComboBox.Items.Add("Urinary System");

            }
            else if (p_GroupComboBox.SelectedItem.ToString() == "Healthcare")
            {
                p_SubGroupComboBox.Enabled = true;
                p_SubGroupComboBox.Items.Clear();
                p_SubGroupComboBox.Items.Add("Cod Liver Oil");
                p_SubGroupComboBox.Items.Add("Chicken Essence");
                p_SubGroupComboBox.Items.Add("Diet");
                p_SubGroupComboBox.Items.Add("Fish Essence");
                p_SubGroupComboBox.Items.Add("Spirulina");
                p_SubGroupComboBox.Items.Add("Vitamin");

            }
            else if (p_GroupComboBox.SelectedItem.ToString() == "Equipment")
            {
                p_SubGroupComboBox.Enabled = true;
                p_SubGroupComboBox.Items.Clear();
                p_SubGroupComboBox.Items.Add("Incontinence");
                p_SubGroupComboBox.Items.Add("Orthopedic");
                p_SubGroupComboBox.Items.Add("Walking Aids");
                p_SubGroupComboBox.Items.Add("Wheelchairs");
                p_SubGroupComboBox.Items.Add("Wound Care");

            }
        }
    }
}
