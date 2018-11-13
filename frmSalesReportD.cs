﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SRePS
{
    public partial class frmSalesReportD : Form
    {
        public frmSalesReportD()
        {
            InitializeComponent();
        }

        private void frmSalesReportD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);

            //hide the salesDetailDataGridView when first load to the form 
            salesDetailDataGridView.Hide();
        }

        private void frmSalesReportD_FormClosing(object sender, FormClosingEventArgs e)
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
                Program.frmSalesD.Dispose();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //make sure that the report datagrid always displayed when Search button is clicked
            salesReportDDataGridView.Show();
            salesDetailDataGridView.Hide();

            //clear any record in the table before fetching a new one so that there are only records for that particular date
            //picked by the user
            if (sRePS_DatabaseDataSet.Tables["DailySalesReport"] != null)
            {
                sRePS_DatabaseDataSet.Tables["DailySalesReport"].Clear();
            }

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            try
            {
                conn.Open();

                string query = "SELECT Sales.S_Date AS Sales_Date, ROUND(SUM(Product.P_Price*[Order].S_Quantity), 2) AS Total_Sales " +
                    "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                    "Product ON [Order].P_ID = Product.P_ID) " +
                    "WHERE Sales.S_Date = @S_Date " +
                    "GROUP BY Sales.S_Date";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@S_Date", dtpicker.Text);
                cmd.ExecuteNonQuery();

                OleDbDataAdapter dSalesReportAdapter = new OleDbDataAdapter(cmd);
                DataSet dSalesReportDataset = new DataSet();
                dSalesReportAdapter.Fill(sRePS_DatabaseDataSet, "DailySalesReport");
                salesReportDDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["DailySalesReport"];
            }
            catch (Exception a)
            {
                MessageBox.Show("Failed to search due to " + a.Message);
            }

            conn.Close();
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

        private void salesReportDDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear any record in the table before fetching a new one
            if (sRePS_DatabaseDataSet.Tables["DailySalesDetail"] != null)
            {
                sRePS_DatabaseDataSet.Tables["DailySalesDetail"].Clear();
            }

            //if user do not double-click on the header
            if (e.RowIndex > -1)
            {
                string selectedDateTime = salesReportDDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                //need to perform split because the value stored contains time, we only need date
                string[] split = selectedDateTime.Split(' ');
                string selectedDate = split[0];

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                try
                {
                    conn.Open();

                    string query = "SELECT Sales.S_Date AS Sales_Date, Sales.Invoice AS Invoice_No, Product.P_Name AS Product_Name, [Order].S_Quantity AS Quantity_Sold, Product.P_Price AS Unit_Price, ROUND(SUM(Product.P_Price*[Order].S_Quantity), 2) AS Total " +
                        "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                        "Product ON [Order].P_ID = Product.P_ID) " +
                        "WHERE Sales.S_Date = @selectedDate " +
                        "GROUP BY Sales.S_Date, Sales.Invoice, Product.P_Name, [Order].S_Quantity, Product.P_Price";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    cmd.ExecuteNonQuery();

                    OleDbDataAdapter dSalesDetailAdapter = new OleDbDataAdapter(cmd);
                    DataSet dSalesDetailDataset = new DataSet();
                    dSalesDetailAdapter.Fill(sRePS_DatabaseDataSet, "DailySalesDetail");
                    salesDetailDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["DailySalesDetail"];

                    //change column size so that it fills up the datagrid
                    salesDetailDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Failed to view due to " + a.Message);
                }

                conn.Close();

                salesDetailDataGridView.Show();
                salesReportDDataGridView.Hide();
            }
            else
            {
                MessageBox.Show("Double-click the row of the record to view the details", "Clicking on header", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "SalesReport.csv";
            if (salesReportDDataGridView.Visible == true)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(filename))
                    {
                        MessageBox.Show(filename + "already exists");
                    }
                    int columnCount = salesReportDDataGridView.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[salesReportDDataGridView.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += salesReportDDataGridView.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; (i - 1) < salesReportDDataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += salesReportDDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                    System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                }
            }
            else if (salesDetailDataGridView.Visible == true)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(filename))
                    {
                        MessageBox.Show(filename + "already exists");
                    }
                    int columnCount = salesDetailDataGridView.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[salesDetailDataGridView.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += salesDetailDataGridView.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; (i - 1) < salesDetailDataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += salesDetailDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        }
                    }
                    System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                }
            }
        }

        private void salesReportDDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1) //Not headers
            {
                lblStatus.Text = "Double-click the row to view details";
            }
        }

        private void salesReportDDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "";
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
