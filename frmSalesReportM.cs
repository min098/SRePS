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
    public partial class frmSalesReportM : Form
    {
        public frmSalesReportM()
        {
            InitializeComponent();
        }

        private void frmSalesReportM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.sRePS_DatabaseDataSet.Sales);

            //hide the salesDetailDataGridView when first load to the form
            salesDetailDataGridView.Hide();

            //Do not allow the user to select end date that is earlier than the start date
            dtpickerEnd.MinDate = dtpickerStart.Value;
        }

        private void frmSalesReportM_FormClosing(object sender, FormClosingEventArgs e)
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

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void btnVisualize_Click(object sender, EventArgs e)
        {

            if(salesReportMDataGridView.Visible)
            {
                if (Program.isOpened(Program.frmVRev) == true)
                {

                    Program.frmVRev.Focus();

                }
                else
                {
                    Program.frmVRev = new frmVRevenue();
                    Program.frmVRev.Show();
                }
            }
            else
            {
                if (Program.isOpened(Program.frmTS) == true)
                {

                    Program.frmTS.Focus();

                }
                else
                {
                    Program.frmTS = new frmVTop();
                    Program.frmTS.Show();
                }
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

        //method to convert the month name to month number
        public string monthDictionary(string month)
        {
            Dictionary<string, int> monthdictionary = new Dictionary<string, int>();

            monthdictionary.Add("January", 1);
            monthdictionary.Add("February", 2);
            monthdictionary.Add("March", 3);
            monthdictionary.Add("April", 4);
            monthdictionary.Add("May", 5);
            monthdictionary.Add("June", 6);
            monthdictionary.Add("July", 7);
            monthdictionary.Add("August", 8);
            monthdictionary.Add("September", 9);
            monthdictionary.Add("October", 10);
            monthdictionary.Add("November", 11);
            monthdictionary.Add("December", 12);

            return monthdictionary[month].ToString();
        }

        //check which condition is run for the search button
        bool sameDate = false;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //make sure that the report datagrid always displayed when Search button is clicked
            salesReportMDataGridView.Show();
            salesDetailDataGridView.Hide();

            //clear any record in the tables before fetching a new one so that there are only records for that particular date
            //picked by the user
            if (sRePS_DatabaseDataSet.Tables["MonthlySalesReport"] != null)
            {
                sRePS_DatabaseDataSet.Tables["MonthlySalesReport"].Clear();
            }

            if (sRePS_DatabaseDataSet.Tables["MonthlySalesDetail"] != null)
            {
                sRePS_DatabaseDataSet.Tables["MonthlySalesDetail"].Clear();
            }

            //startDate
            string pickedSMonthYear = dtpickerStart.Text;
            string[] splitSMonthYear = pickedSMonthYear.Split(' ');
            string pickedSMonth = splitSMonthYear[0];
            string pickedSYear = splitSMonthYear[1];
            string pickedSDate = "1/" + monthDictionary(pickedSMonth) + "/" + pickedSYear;

            //endDate
            string pickedEMonthYear = dtpickerEnd.Text;
            string[] splitEMonthYear = pickedEMonthYear.Split(' ');
            string pickedEMonth = splitEMonthYear[0];
            string pickedEYear = splitEMonthYear[1];
            int endofmonth = DateTime.DaysInMonth(Convert.ToInt32(pickedEYear), Convert.ToInt32(monthDictionary(pickedEMonth)));
            string pickedEDate = endofmonth.ToString() + "/" + pickedEMonth + "/" + pickedEYear;


            //if picked the same date, display that month's sales report
            if (pickedSMonthYear == pickedEMonthYear)
            {
                sameDate = true;

                //call the method to display the sales detail of the selected month and year
                displaySalesDetail(monthDictionary(pickedSMonth), pickedSYear); //the variable pickedSMonth is storing month name so need to convert to number
            }
            else
            {
                sameDate = false;

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                try
                {
                    conn.Open();

                    string query = "SELECT MONTH(Sales.S_Date) AS Sales_Month, YEAR(Sales.S_Date) AS Sales_Year, SUM(Product.P_Price*[Order].S_Quantity) AS Total_Sales " +
                        "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                        "Product ON [Order].P_ID = Product.P_ID) " +
                        "WHERE (Sales.S_Date >= @startDate) AND (Sales.S_Date <= @endDate) " +
                        "GROUP BY YEAR(Sales.S_Date), MONTH(Sales.S_Date)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", pickedSDate);
                    cmd.Parameters.AddWithValue("@endDate", pickedEDate);
                    cmd.ExecuteNonQuery();

                    OleDbDataAdapter mSalesReportAdapter = new OleDbDataAdapter(cmd);
                    DataSet mSalesReportDataset = new DataSet();
                    mSalesReportAdapter.Fill(sRePS_DatabaseDataSet, "MonthlySalesReport");
                    salesReportMDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["MonthlySalesReport"];
                }
                catch (Exception a)
                {
                    MessageBox.Show("Failed to search due to " + a.Message);
                }

                conn.Close();
            }
        }

        private void salesReportMDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear any record in the table before fetching a new one
            if (sRePS_DatabaseDataSet.Tables["MonthlySalesDetail"] != null)
            {
                sRePS_DatabaseDataSet.Tables["MonthlySalesDetail"].Clear();
            }

            //if user do not double-click on the header
            if (e.RowIndex > -1)
            {
                string selectedMonth = salesReportMDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string selectedYear = salesReportMDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                //call the method to display the sales detail of the selected month and year
                displaySalesDetail(selectedMonth, selectedYear);
            }
            else if (sameDate == false)  //the double-click to view details feature only available when the date picked are not the same
            {
                MessageBox.Show("Double-click the row of the record to view the details", "Clicking on header", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //a method to reduce duplicate code for displaying sales detail
        private void displaySalesDetail(string selectedMonth, string selectedYear)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            try
            {
                conn.Open();

                string query = "SELECT Sales.S_Date AS Sales_Date, Sales.Invoice AS Invoice_No, Product.P_Name AS Product_Name, [Order].S_Quantity AS Quantity_Sold, Product.P_Price AS Unit_Price, SUM(Product.P_Price*[Order].S_Quantity) AS Total " +
                    "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                    "Product ON [Order].P_ID = Product.P_ID) " +
                    "WHERE (MONTH(Sales.S_Date) = @selectedMonth) AND (YEAR(Sales.S_Date) = @selectedYear) " +
                    "GROUP BY Sales.S_Date, Sales.Invoice, Product.P_Name, [Order].S_Quantity, Product.P_Price";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth);
                cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter mSalesDetailAdapter = new OleDbDataAdapter(cmd);
                DataSet mSalesDetailDataset = new DataSet();
                mSalesDetailAdapter.Fill(sRePS_DatabaseDataSet, "MonthlySalesDetail");
                salesDetailDataGridView.DataSource = sRePS_DatabaseDataSet.Tables["MonthlySalesDetail"];
            }
            catch (Exception a)
            {
                MessageBox.Show("Failed to view due to " + a.Message);
            }

            conn.Close();

            salesDetailDataGridView.Show();
            salesReportMDataGridView.Hide();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (salesReportMDataGridView.Visible == true)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(filename))
                    {
                        MessageBox.Show(filename + "already exists");
                    }
                    int columnCount = salesReportMDataGridView.ColumnCount;
                    string columnNames = "";
                    string[] output = new string[salesReportMDataGridView.RowCount + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += salesReportMDataGridView.Columns[i].Name.ToString() + ",";
                    }
                    output[0] += columnNames;
                    for (int i = 1; (i - 1) < salesReportMDataGridView.RowCount; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            output[i] += salesReportMDataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
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

        private void salesReportMDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1) //Not headers
            {
                lblStatus.Text = "Double-click the row to view details";
            }
        }

        private void salesReportMDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "";
        }

        private void dtpickerStart_CloseUp(object sender, EventArgs e)
        {
            //Do not allow the user to select end date that is earlier than the start date
            dtpickerEnd.MinDate = dtpickerStart.Value;
        }
    }
}
