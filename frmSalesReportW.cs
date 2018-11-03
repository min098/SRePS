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
using System.IO;

namespace SRePS
{
    public partial class frmSalesReportW : Form
    {
        public frmSalesReportW()
        {
            InitializeComponent();
        }

        private void frmSalesReportW_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);

            //hide the salesDetailDataGridView when first load to the form
            salesDetailDataGridView.Hide();

            //automatically select the end date that is 6 days after the start date 
            dtpickerEnd.Value = dtpickerStart.Value.AddDays(6);
        }

        private void frmSalesReportW_FormClosing(object sender, FormClosingEventArgs e)
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
                Program.frmSalesM.Dispose();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //make sure that the report datagrid always displayed when Search button is clicked
            salesReportWDataGridView.Show();
            salesDetailDataGridView.Hide();

            //clear any record in the table before fetching a new one so that there are only records for that particular date
            //picked by the user
            if (sRePS_DatabaseDataSet.Tables["WeeklySalesReport"] != null)
            {
                sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Clear();
            }

            //startDate
            string pickedSDateName = dtpickerStart.Text;
            string[] splitSDateName = pickedSDateName.Split(' ');
            string pickedSDate = splitSDateName[0];
            string pickedSName = splitSDateName[1];

            //endDate
            string pickedEDateName = dtpickerEnd.Text;
            string[] splitEDateName = pickedEDateName.Split(' ');
            string pickedEDate = splitEDateName[0];

            if (pickedSDate != pickedEDate)
            {
                if (pickedSName == "Monday")
                {
                    string[] splitSDate = pickedSDate.Split('/');
                    int startday = Convert.ToInt32(splitSDate[0]);
                    //Convert to int to check the range
                    string[] splitEDate = pickedEDate.Split('/');
                    int endday = Convert.ToInt32(splitEDate[0]);

                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                    try
                    {
                        conn.Open();

                        string query = "SELECT Sales.S_Date AS Sales_Date, [Order].Inv_No AS Invoice_No, SUM(Product.P_Price*[Order].S_Quantity) AS Total_Sales " +
                            "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                            "Product ON [Order].P_ID = Product.P_ID) " +
                            "WHERE (Sales.S_Date >= @startDate) AND (Sales.S_Date <= @endDate) " +
                            "GROUP BY Sales.S_Date, [Order].Inv_No";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@startDate", pickedSDate);
                        cmd.Parameters.AddWithValue("@endDate", pickedEDate);
                        cmd.ExecuteNonQuery();

                        OleDbDataAdapter wSalesReportAdapter = new OleDbDataAdapter(cmd);
                        DataSet wSalesReportDataset = new DataSet();
                        wSalesReportAdapter.Fill(sRePS_DatabaseDataSet, "WeeklySalesReport");

                        //only create the new column when it is not in the table
                        if (!sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Columns.Contains("DayOfTheWeek"))
                        {
                            DataColumn days = new DataColumn("DayOfTheWeek", typeof(string));
                            sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Columns.Add(days);
                            days.SetOrdinal(0); //change the position of the new column to the first column in the table
                        }

                        for (int i = 0; i < sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Rows.Count; i++)
                        {
                            //display the day of week in the newly created column according to the date of that row
                            sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Rows[i]["DayOfTheWeek"] = Convert.ToDateTime(sRePS_DatabaseDataSet.Tables["WeeklySalesReport"].Rows[i][1]).DayOfWeek.ToString();
                        }

                        salesReportWDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["WeeklySalesReport"];
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Failed to search due to " + a.Message);
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("The start date must be Monday!", "Start date error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Start date and end date should not be the same", "Start date and End date error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void salesReportWDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear any record in the table before fetching a new one
            if (sRePS_DatabaseDataSet.Tables["DailySalesDetail"] != null)
            {
                sRePS_DatabaseDataSet.Tables["DailySalesDetail"].Clear();
            }

            //if user do not double-click on the header
            if (e.RowIndex > -1)
            {
                string selectedDateTime = salesReportWDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //need to perform split because the value stored contains time, we only need date
                string[] split = selectedDateTime.Split(' ');
                string selectedDate = split[0];

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                try
                {
                    conn.Open();

                    string query = "SELECT Sales.S_Date AS Sales_Date, [Order].Inv_No AS Invoice_No, Product.P_Name AS Product_Name, [Order].S_Quantity AS Quantity_Sold, Product.P_Price AS Unit_Price " +
                        "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                        "Product ON [Order].P_ID = Product.P_ID) " +
                        "WHERE Sales.S_Date = @selectedDate";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    cmd.ExecuteNonQuery();

                    OleDbDataAdapter wSalesDetailAdapter = new OleDbDataAdapter(cmd);
                    DataSet wSalesDetailDataset = new DataSet();
                    wSalesDetailAdapter.Fill(sRePS_DatabaseDataSet, "DailySalesDetail");
                    salesDetailDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["DailySalesDetail"];

                    //change column size so that it fills up the datagrid
                    salesDetailDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    salesDetailDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Failed to view due to " + a.Message);
                }

                conn.Close();

                salesDetailDataGridView.Show();
                salesReportWDataGridView.Hide();
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
            sfd.FileName = "Output.csv";
            if (salesReportWDataGridView.Visible == true)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(filename))
                    {
                        MessageBox.Show(filename + "already exists");
                    }
                    int columnCount = salesReportWDataGridView.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[salesReportWDataGridView.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += salesReportWDataGridView.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; (i - 1) < salesReportWDataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += salesReportWDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        private void salesReportWDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1) //Not headers
            {
                lblStatus.Text = "Double-click the row to view details";
            }
        }

        private void salesReportWDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "";
        }

        private void dtpickerStart_ValueChanged(object sender, EventArgs e)
        {
            //startDate
            string pickedSDateName = dtpickerStart.Text;
            string pickedSName = pickedSDateName.Split(' ')[1];

            //inform user that the start date must be Monday
            if (pickedSName != "Monday")
            {
                MessageBox.Show("The start date must be Monday!", "Start date error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpickerStart.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpickerStart_CloseUp(object sender, EventArgs e)
        {
            //automatically select the end date that is 6 days after the start date 
            dtpickerEnd.Value = dtpickerStart.Value.AddDays(6);
        }
    }
}
