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
    public partial class frmEditProduct : Form
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }

        private void lblPCost_Click(object sender, EventArgs e)
        {

        }

        private void lblPQuantity_Click(object sender, EventArgs e)
        {

        }

        public Boolean isUserNameExists()
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            con.Open();
            OleDbDataReader read;
            string query = "SELECT * FROM Product WHERE [P_ID]=?";
            OleDbCommand cmd = new OleDbCommand(query, con);

            cmd.Parameters.AddWithValue("P_ID", p_IDTextBox.Text);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read.HasRows == true)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            string oldID = Program.frmProduct.productDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            if (p_IDTextBox.Text == "" || p_NameTextBox.Text == "" || p_QuantityUpDown.Value < 0 || p_PriceTextBox.Text == "" || p_CostTextBox.Text == ""
                || p_SupplierTextBox.Text == "" || cmbPUOM.SelectedItem == null || cmbPGroup.SelectedItem == null
                || cmbPSubGroup.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "UPDATE [Product] SET [P_ID]=@P_ID,[P_Name]=@P_Name,[P_Quantity]=@P_Quantity,[P_Price]=@P_Price,[P_Cost]=@P_Cost," +
                        "[P_Supplier]=@P_Supplier,[P_UOM]=@P_UOM,[P_Group]=@P_Group,[P_SubGroup]=@P_SubGroup,[P_Archive]=@P_Archive WHERE [P_ID] = @oldID";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    if (p_IDTextBox.Text == oldID)
                    {
                        cmd.Parameters.AddWithValue("P_ID", p_IDTextBox.Text);
                    }
                    else if (isUserNameExists() == true)
                    {
                        MessageBox.Show("Product ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("P_ID", p_IDTextBox.Text);
                    }
                    cmd.Parameters.AddWithValue("@P_Name", p_NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@P_Quantity", p_QuantityUpDown.Value);
                    cmd.Parameters.AddWithValue("@P_Price", p_PriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@P_Cost", p_CostTextBox.Text);
                    cmd.Parameters.AddWithValue("@P_Supplier", p_SupplierTextBox.Text);
                    cmd.Parameters.AddWithValue("@P_UOM", cmbPUOM.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@P_Group", cmbPGroup.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@P_SubGroup", cmbPSubGroup.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@oldID", oldID);
                    bool isChecked = rdTrue.Checked;
                    if (isChecked)
                    {
                        cmd.Parameters.AddWithValue("@P_Archive", rdTrue.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@P_Archive", rdFalse.Text);
                    }


                    //The selling price must not lower than cost
                    if (Convert.ToDouble(p_PriceTextBox.Text) < Convert.ToDouble(p_CostTextBox.Text))
                    {
                        MessageBox.Show("Selling price must not be lower than cost!");
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edit Successfully");
                    Program.frmProduct.productTableAdapter.Fill(Program.frmProduct.sRePS_DatabaseDataSet.Product);
                    this.Close();
                }
                catch (Exception)
                {

                }
                con.Close();

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
                Program.frmEditP.Dispose();

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

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmEditProduct_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmEditProduct_Load(object sender, EventArgs e)
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

        private void cmbPGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPGroup.SelectedItem.ToString() == "Medicine")
            {
                cmbPSubGroup.Text = "--Select the sub group of product--";
                cmbPSubGroup.Items.Clear();
                cmbPSubGroup.Items.Add("Allergic");
                cmbPSubGroup.Items.Add("Birth Control");
                cmbPSubGroup.Items.Add("Central Nervous System");
                cmbPSubGroup.Items.Add("Circulatory System");
                cmbPSubGroup.Items.Add("Cough");
                cmbPSubGroup.Items.Add("Digestive System");
                cmbPSubGroup.Items.Add("Ear");
                cmbPSubGroup.Items.Add("Eye");
                cmbPSubGroup.Items.Add("Endocrine System");
                cmbPSubGroup.Items.Add("Fever");
                cmbPSubGroup.Items.Add("Immune System");
                cmbPSubGroup.Items.Add("Menstrual Pain");
                cmbPSubGroup.Items.Add("Musculoskeletal Disorders");
                cmbPSubGroup.Items.Add("Nose");
                cmbPSubGroup.Items.Add("Pain and Consciousness");
                cmbPSubGroup.Items.Add("Reproductive System");
                cmbPSubGroup.Items.Add("Respiratory System");
                cmbPSubGroup.Items.Add("Throat");
                cmbPSubGroup.Items.Add("Skin");
                cmbPSubGroup.Items.Add("Urinary System");


            }
            else if (cmbPGroup.SelectedItem.ToString() == "Healthcare")
            {
                cmbPSubGroup.Text = "--Select the sub group of product--";
                cmbPSubGroup.Items.Clear();
                cmbPSubGroup.Items.Add("Cod Liver Oil");
                cmbPSubGroup.Items.Add("Chicken Essence");
                cmbPSubGroup.Items.Add("Diet");
                cmbPSubGroup.Items.Add("Fish Essence");
                cmbPSubGroup.Items.Add("Spirulina");
                cmbPSubGroup.Items.Add("Vitamin");

            }
            else if (cmbPGroup.SelectedItem.ToString() == "Equipment")
            {
                cmbPSubGroup.Text = "--Select the sub group of product--";
                cmbPSubGroup.Items.Clear();
                cmbPSubGroup.Items.Add("Incontinence");
                cmbPSubGroup.Items.Add("Orthopedic");
                cmbPSubGroup.Items.Add("Walking Aids");
                cmbPSubGroup.Items.Add("Wheelchairs");
                cmbPSubGroup.Items.Add("Wound Care");
            }
        }
    }
}
