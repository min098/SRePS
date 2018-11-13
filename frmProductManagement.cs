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
    public partial class frmProductManagement : Form
    {
        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void productManagement_Load(object sender, EventArgs e)
        {

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.sRePS_DatabaseDataSet.Order);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sRePS_DatabaseDataSet.Product);

        }

        private void addProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource2.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sRePS_DatabaseDataSet);
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void p_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
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
            else
            {
                MessageBox.Show("Only admin can add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
                if (productDataGridView.SelectedRows.Count != 0)
                {
                    int rowIndex = productDataGridView.CurrentRow.Index;
                    //Get the deleted row P_ID
                    string deletingPid = productDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                    DataRow[] foundPID = sRePS_DatabaseDataSet.Order.Select("P_ID = '" + deletingPid + "'");
                    //Check if the deleting product is existing in the Order table
                    if (foundPID.Length != 0)
                    {
                        if (productDataGridView.SelectedRows[0].Cells[6].Value.ToString() == "False")
                        {
                            DialogResult dialogResult = MessageBox.Show("This record cannot be deleted as this product sold before, but you can archieve it. Do you want to archive this record?", "Archiving record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.Yes)
                            {
                                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                                con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;
                                con.Open();
                                string query = "UPDATE [Product] SET [P_Archive]=? WHERE [P_ID]=?";
                                OleDbCommand cmd = new OleDbCommand(query, con);
                                cmd.Parameters.AddWithValue("P_Archive", "True");
                                cmd.Parameters.AddWithValue("P_ID", deletingPid);
                                cmd.ExecuteNonQuery();
                                con.Close();

                                //update the datagrid
                                productTableAdapter.Fill(sRePS_DatabaseDataSet.Product);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("This record is already archieved.", "Archiving error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        //Pop up confirmation box
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.sRePS_DatabaseDataSet.Product.Rows[rowIndex].Delete();
                            productTableAdapter.Update(sRePS_DatabaseDataSet);
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
                        MessageBox.Show("You have made changes to the Product table, please reopen the Add Sales window");
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
                MessageBox.Show("Only admin can delete product record.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProductManagement_FormClosing(object sender, FormClosingEventArgs e)
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
            else if (Program.isOpened(Program.frmAddP))
            {
                Program.frmAddP.Focus();
                e.Cancel = true;
            }
            else if (Program.isOpened(Program.frmEditP))
            {
                Program.frmEditP.Focus();
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
                this.Dispose();

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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
                if (productDataGridView.SelectedRows.Count != 0)
                {
                    if (Program.isOpened(Program.frmEditP) == true)
                    {

                        Program.frmEditP.Focus();

                    }
                    else
                    {
                        Program.frmEditP = new frmEditProduct();
                        Program.frmEditP.Show();
                        Program.frmEditP.p_IDTextBox.Text = this.productDataGridView.CurrentRow.Cells[0].Value.ToString();
                        Program.frmEditP.p_NameTextBox.Text = this.productDataGridView.CurrentRow.Cells[1].Value.ToString();

                        if (this.productDataGridView.CurrentRow.Cells[2].Value.ToString() == "Equipment")
                        {
                            Program.frmEditP.cmbPGroup.SelectedItem = "Equipment";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[2].Value.ToString() == "Healthcare")
                        {
                            Program.frmEditP.cmbPGroup.SelectedItem = "Healthcare";
                        }
                        else
                        {
                            Program.frmEditP.cmbPGroup.SelectedItem = "Medicine";
                        }

                        if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Allergic")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Allergic";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Birth Control")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Birth Control";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Central Nervous System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Central Nervous System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Circulatory System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Circulatory System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Cough")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Cough";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Digestive System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Digestive System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Ear")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Ear";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Eye")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Eye";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Endocrine System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Endocrine System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Fever")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Fever";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Immune System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Immune System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Menstrual Pain")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Menstrual Pain";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Musculoskeletal Disorders")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Musculoskeletal Disorders";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Nose")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Nose";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Pain and Consciousness")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Pain and Consciousness";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Reproductive System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Reproductive System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Respiratory System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Respiratory System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Throat")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Throat";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Skin")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Skin";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Urinary System")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Urinary System";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Cod Liver Oil")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Cod Liver Oil";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Chicken Essence")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Chicken Essence";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Diet")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Diet";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Fish Essence")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Fish Essence";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Spirulina")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Spirulina";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Vitamin")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Vitamin";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Incontinence")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Incontinence";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Orthopedic")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Orthopedic";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Walking Aids")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Walking Aids";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[3].Value.ToString() == "Wheelchairs")
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Wheelchairs";
                        }
                        else
                        {
                            Program.frmEditP.cmbPSubGroup.SelectedItem = "Wound Care";
                        }

                        if (this.productDataGridView.CurrentRow.Cells[4].Value.ToString() == "Bottle")
                        {
                            Program.frmEditP.cmbPUOM.SelectedItem = "Bottle";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[4].Value.ToString() == "Pcs")
                        {
                            Program.frmEditP.cmbPUOM.SelectedItem = "Pcs";
                        }
                        else if (this.productDataGridView.CurrentRow.Cells[4].Value.ToString() == "Tablet")
                        {
                            Program.frmEditP.cmbPUOM.SelectedItem = "Tablet";
                        }
                        else
                        {
                            Program.frmEditP.cmbPUOM.SelectedItem = "Gram";
                        }


                        Program.frmEditP.p_QuantityUpDown.Value = Convert.ToInt32(this.productDataGridView.CurrentRow.Cells[5].Value);

                        if (this.productDataGridView.CurrentRow.Cells[6].Value.ToString() == "True")
                        {
                            Program.frmEditP.rdTrue.Checked = true;
                        }
                        else
                        {
                            Program.frmEditP.rdFalse.Checked = true;

                        }

                        string oldID = Program.frmProduct.productDataGridView.SelectedRows[0].Cells[0].Value.ToString();


                        System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                        conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                        conn.Open();
                        OleDbDataReader read;
                        string my_query = "SELECT * FROM Product WHERE [P_ID]=?";
                        OleDbCommand cmd = new OleDbCommand(my_query, conn);
                        cmd.Parameters.AddWithValue("P_ID", oldID);

                        read = cmd.ExecuteReader();
                        while (read.Read())
                        {
                            Program.frmEditP.p_PriceTextBox.Text = read["P_Price"].ToString();
                            Program.frmEditP.p_CostTextBox.Text = read["P_Cost"].ToString();
                            Program.frmEditP.p_SupplierTextBox.Text = read["P_Supplier"].ToString();

                        }
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("No row has been selected. Please select a row to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Only admin can edit product record.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //if the record is archieved, set the text color to white
        private void productDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < productDataGridView.Rows.Count; i++)
            {
                string value = sRePS_DatabaseDataSet.Product.Rows[i][9].ToString();
                int quantity = Convert.ToInt32(productDataGridView.Rows[i].Cells[5].Value);

                if (value == "True")
                {
                    productDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                }

                if (quantity < 10)
                {
                    productDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
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

