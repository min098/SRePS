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
    public partial class frmSalesManagement : Form
    {
        public frmSalesManagement()
        {
            InitializeComponent();
        }

        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Employees);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sRePS_DatabaseDataSet.Product);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.SalesManagement' table. You can move, or remove it, as needed.
            this.salesManagementTableAdapter.Fill(this.sRePS_DatabaseDataSet.SalesManagement);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.sRePS_DatabaseDataSet.Order);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);

            //hide the salesMngDetailDataGridView when first load to the form 
            salesMngDetailDataGridView.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void frmSalesManagement_FormClosing(object sender, FormClosingEventArgs e)
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
            else if (Program.isOpened(Program.frmEditS))
            {
                Program.frmEditS.Focus();
                e.Cancel = true;
            }
        }

        public OleDbDataAdapter salesMngDetailAdapter;

        private void btnEditSales_Click(object sender, EventArgs e)
        {
            if (Program.curPosition == "Admin")
            {
                if (salesDataGridView.Visible)  //the displayed datagrid is salesDataGrid
                {
                    if (salesDataGridView.SelectedRows.Count != 0)
                    {
                        //clear any record in the table before fetching a new one
                        if (sRePS_DatabaseDataSet.Tables["SalesManagementDetail"] != null)
                        {
                            sRePS_DatabaseDataSet.Tables["SalesManagementDetail"].Clear();
                        }

                        string selectedInvNo = salesDataGridView.SelectedRows[0].Cells[2].Value.ToString();

                        OleDbConnection conn = new OleDbConnection();
                        conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                        try
                        {
                            conn.Open();

                            string query = "SELECT Sales.Invoice AS Invoice_No, Sales.S_Date AS Sales_Date, Employees.E_ID AS Employee_ID, Product.P_ID AS Product_ID, [Order].S_Quantity AS Quantity_Sold " +
                                "FROM (((Product INNER JOIN [Order] ON Product.P_ID = [Order].P_ID) " +
                                "INNER JOIN Sales ON [Order].Inv_No = Sales.Inv_No) " +
                                "INNER JOIN Employees ON Sales.E_ID = Employees.E_ID) " +
                                "WHERE [Order].Inv_No = @selectedInvNo";
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            cmd.Parameters.AddWithValue("@selectedInvNo", selectedInvNo);
                            cmd.ExecuteNonQuery();

                            salesMngDetailAdapter = new OleDbDataAdapter(cmd);
                            DataSet salesMngDetailDataset = new DataSet();
                            salesMngDetailAdapter.Fill(sRePS_DatabaseDataSet, "SalesManagementDetail");
                            salesMngDetailDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["SalesManagementDetail"];

                            //change column size so that it fills up the datagrid
                            salesMngDetailDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            salesMngDetailDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            salesMngDetailDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            salesMngDetailDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                            salesMngDetailDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Failed to view due to " + a.Message);
                        }

                        conn.Close();

                        salesMngDetailDataGridView.Show();
                        salesDataGridView.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No row has been selected. Please select a row to edit", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (salesMngDetailDataGridView.Visible) //the displayed datagrid is salesMngDetailDataGrid (after double-clicked)
                {
                    if (salesMngDetailDataGridView.SelectedRows.Count != 0)
                    {
                        if (Program.isOpened(Program.frmEditS) == true)
                        {
                            Program.frmEditS.Focus();
                        }
                        else
                        {
                            Program.frmEditS = new frmEditSales();
                            Program.frmEditS.Show();
                            Program.frmEditS.lblInvoiceNo.Text = this.salesMngDetailDataGridView.CurrentRow.Cells[0].Value.ToString();
                            Program.frmEditS.dtpickerSalesDate.Text = this.salesMngDetailDataGridView.CurrentRow.Cells[1].Value.ToString();
                            Program.frmEditS.txtEID.Text = this.salesMngDetailDataGridView.CurrentRow.Cells[2].Value.ToString();
                            Program.frmEditS.txtPID.Text = this.salesMngDetailDataGridView.CurrentRow.Cells[3].Value.ToString();
                            Program.frmEditS.txtSQty.Text = this.salesMngDetailDataGridView.CurrentRow.Cells[4].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No row has been selected. Please select a row to edit", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Only admin can edit sales record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;
            if (salesDataGridView.Visible)
            {
                if (Program.curPosition == "Admin")
                {
                    if (salesDataGridView.SelectedRows.Count != 0)
                    {
                        int rowIndex = salesDataGridView.CurrentRow.Index;
                        string selectedInvNo = salesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Deleting sales", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == DialogResult.Yes)
                        {

                            con.Open();
                            string query3 = "UPDATE [Product] SET [P_Quantity]=P_Quantity+@quantityChanged WHERE [P_ID]=?";
                            OleDbCommand cmd3 = new OleDbCommand(query3, con);

                            for (int i = 0; i < this.sRePS_DatabaseDataSet.Order.Rows.Count; i++)
                            {
                                DataRow row = this.sRePS_DatabaseDataSet.Order.Rows[i];

                                //update the quantity back to Product
                                if (Convert.ToInt32(row[1]) == Convert.ToInt32(selectedInvNo))
                                {
                                    cmd3.Parameters.AddWithValue("@quantityChanged", Convert.ToInt32(row[2]));
                                    cmd3.Parameters.AddWithValue("P_ID", Convert.ToInt32(row[0]));
                                    cmd3.ExecuteNonQuery();
                                    cmd3.Parameters.Clear();
                                    row.Delete();
                                }
                            }

                            con.Close();

                            this.sRePS_DatabaseDataSet.Sales.Rows[rowIndex].Delete();
                            salesTableAdapter.Update(sRePS_DatabaseDataSet);


                            if (Program.isOpened(Program.frmProduct) == true)
                            {
                                Program.frmProduct.productTableAdapter.Fill(Program.frmProduct.sRePS_DatabaseDataSet.Product);
                            }

                            if (Program.isOpened(Program.frmAddS) == true)
                            {
                                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                                conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;
                                string inv = "SELECT MAX(Inv_No) FROM Sales";
                                OleDbCommand cmd = new OleDbCommand(inv, conn);
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection.Open();
                                object obj = cmd.ExecuteScalar();
                                if (string.IsNullOrEmpty(obj.ToString()))
                                {
                                    Program.frmAddS.lblInv_No.Text = "1";
                                }
                                else
                                {
                                    Program.frmAddS.lblInv_No.Text = Convert.ToString(Convert.ToInt32(obj.ToString()) + 1);
                                }

                            }

                            salesManagementTableAdapter.Fill(Program.frmSales.sRePS_DatabaseDataSet.SalesManagement);

                            if (salesMngDetailDataGridView.Visible)
                            {
                                salesMngDetailAdapter.Fill(Program.frmSales.sRePS_DatabaseDataSet.SalesManagement);
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("No row has been selected. Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Only admin can delete sales record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Cannot delete sales at Sale Detail page." + "\n" + "Redirect back to Sales Management page for delete action?", "Deleting sales", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    salesMngDetailDataGridView.Hide();
                    salesDataGridView.Show();
                }


            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
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

        private void toolStripBtnBack_Click(object sender, EventArgs e)
        {
            salesDataGridView.Show();
            salesMngDetailDataGridView.Hide();
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

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salesMngDetailDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
