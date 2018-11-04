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
    public partial class frmAddSales : Form
    {
        public frmAddSales()
        {
            InitializeComponent();
        }

        private void btnManage_Click(object sender, EventArgs e)
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

        //add the item into datagrid for review, not yet adding to database
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            //select last row
            itemGrid.ClearSelection();
            

            try
            {

                conn.Open();
                string my_query = "SELECT P_ID, P_Name, P_Price from Product where P_ID= @P_ID";
                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.Parameters.AddWithValue("@P_ID", barcodeTextBox.Text);
                cmd.ExecuteNonQuery();
                int numRows = itemGrid.Rows.Count;
                //check if the product is existed in database or not
                bool readerHasRows = false;
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    readerHasRows = (reader != null && reader.HasRows);
                }

                if (readerHasRows)
                {
                    //get the selectedProductRow to retrieve the value of the P_Archive column
                    DataRow selectedProductRow = sRePS_DatabaseDataSet.Product.Select("P_ID = '" + barcodeTextBox.Text + "'")[0];
                    if (selectedProductRow[9].ToString() == "False")
                    {

                        //check if the quantity inserted is higher than the quantity in database, so retrieve the value of P_Quantity from database
                        string quantity = "SELECT P_Quantity FROM Product";
                        OleDbCommand cmd2 = new OleDbCommand(quantity, conn);
                        cmd2.CommandType = CommandType.Text;
                        int stock = Convert.ToInt32(cmd2.ExecuteScalar());

                        //NOTE: changed some code here
                        //compare the stock in database with the quantity entered, if quantity entered is greater than the stock, then pop up error message
                        if (Convert.ToDouble(quantityTextBox.Text) <= stock)
                        {
                            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(cmd);
                            DataSet addItemDataSet = new DataSet();

                            Boolean found = false;

                            if (itemGrid.Rows.Count > 1)
                            {
                                for (int i = 0; i < sRePS_DatabaseDataSet.Tables["AddItem"].Rows.Count; i++)
                                {
                                    if (sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["P_ID"].ToString() == barcodeTextBox.Text)
                                    {
                                        sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["Quantity"] = Convert.ToString(Convert.ToDouble(quantityTextBox.Text) + Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["Quantity"]));
                                        sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["Total"] = Convert.ToString(Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["Quantity"]) * Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[i]["P_Price"]));
                                        found = true;
                                        break;
                                    }
                                }

                                if (found == false)
                                {
                                    int index = sRePS_DatabaseDataSet.Tables["AddItem"].Rows.Count;

                                    myDataAdapter.Fill(sRePS_DatabaseDataSet, "AddItem");
                                    itemGrid.DataSource = sRePS_DatabaseDataSet.Tables["AddItem"];
                                    sRePS_DatabaseDataSet.Tables["AddItem"].Rows[index]["Quantity"] = Convert.ToDouble(quantityTextBox.Text);
                                    sRePS_DatabaseDataSet.Tables["AddItem"].Rows[index]["Total"] = Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[index]["Quantity"]) * Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[index]["P_Price"]);
                                }
                            }
                            else
                            {
                                myDataAdapter.Fill(sRePS_DatabaseDataSet, "AddItem");
                                itemGrid.DataSource = sRePS_DatabaseDataSet.Tables["AddItem"];

                                //create two new columns in the datatable
                                //only create them when they are not in the table
                                if (!sRePS_DatabaseDataSet.Tables["AddItem"].Columns.Contains("Quantity") &&
                                !sRePS_DatabaseDataSet.Tables["AddItem"].Columns.Contains("Total"))
                                {
                                    DataColumn pQty = new DataColumn("Quantity");
                                    DataColumn pTtl = new DataColumn("Total");
                                    sRePS_DatabaseDataSet.Tables["AddItem"].Columns.Add(pQty);
                                    sRePS_DatabaseDataSet.Tables["AddItem"].Columns.Add(pTtl);
                                }

                                sRePS_DatabaseDataSet.Tables["AddItem"].Rows[0]["Quantity"] = Convert.ToDouble(quantityTextBox.Text);
                                sRePS_DatabaseDataSet.Tables["AddItem"].Rows[0]["Total"] = Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[0]["Quantity"]) * Convert.ToDouble(sRePS_DatabaseDataSet.Tables["AddItem"].Rows[0]["P_Price"]);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Not enough stock!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found!"); //archived
                    }
                }
                else
                {
                    MessageBox.Show("Product not found!");
                }
                
                barcodeTextBox.Focus(); //Focus back to the barcode text box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add due to " + ex.Message);
            }
            finally
            {
                conn.Close();
                barcodeTextBox.Clear();
                quantityTextBox.Clear();
            }

        }

        private void frmAddSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sRePS_DatabaseDataSet.Product);

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            //set the new Inv_No as a label that display in the Add Sales page
            string inv = "SELECT MAX(Inv_No) FROM Sales";
            OleDbCommand cmd = new OleDbCommand(inv, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            object obj = cmd.ExecuteScalar();
            if (string.IsNullOrEmpty(obj.ToString()))
            {
                lblInv_No.Text = "1";
            }
            else
            {
                lblInv_No.Text = Convert.ToString(Convert.ToInt32(obj.ToString()) + 1);
            }
        }

        private void itemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (itemGrid.Rows.Count != 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove item?", "Removing Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    //sRePS_DatabaseDataSet.Tables["AddItem"].Rows.RemoveAt(itemGrid.CurrentRow.Index);
                    itemGrid.Rows.RemoveAt(itemGrid.CurrentRow.Index);
                    sRePS_DatabaseDataSet.Tables["AddItem"].AcceptChanges();
                }

                //DialogResult result = MessageBox.Show("Remove "  + itemGrid.CurrentRow.Cells[1].Value.ToString() +"?" , "Removing Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all rows
            if (itemGrid.Rows.Count != 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear all added items?", "Clearing added items", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    if (sRePS_DatabaseDataSet.Tables["AddItem"] != null)
                    {
                        sRePS_DatabaseDataSet.Tables["AddItem"].Clear();
                    }
                }
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (sRePS_DatabaseDataSet.Tables["AddItem"] != null)
            {
                Program.frmP = new frmPayment();
                Program.frmP.Show();
            }
            else
            {
                MessageBox.Show("No sales to be committed!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityTextBox.Text = "1";
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddSales_FormClosing(object sender, FormClosingEventArgs e)
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
            else if (Program.isOpened(Program.frmP))
            {
                Program.frmP.Focus();
                e.Cancel = true;
            }
        }
    }
}
