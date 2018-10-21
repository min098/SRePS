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

        //method to convert the month name to month number
        private string monthDictionary(string month)
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
                if (Convert.ToDateTime(pickedEMonthYear) > Convert.ToDateTime(pickedSMonthYear))
                {
                    sameDate = false;

                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

                    try
                    {
                        conn.Open();

                        string query = "SELECT MONTH(Sales.S_Date) AS Sales_Month, YEAR(Sales.S_Date) AS Sales_Year, SUM(Product.P_Price*[Order].S_Quantity) AS Total " +
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
                else
                {
                    MessageBox.Show("The start month must be earlier than the end month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                //if the clicked column is Month
                if (e.ColumnIndex == 0)
                {
                    string selectedMonth = salesReportMDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string selectedYear = salesReportMDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                    //call the method to display the sales detail of the selected month and year
                    displaySalesDetail(selectedMonth, selectedYear);
                }
            }
            else if (sameDate == false)  //the double-click to view details feature only available when the date picked are not the same
            {
                MessageBox.Show("Double-click the month of the record to view the details", "Clicking on header", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                string query = "SELECT Sales.S_Date AS Sales_Date, [Order].Inv_No, Product.P_Name AS Product_Name, [Order].S_Quantity AS Quantity_Sold, Product.P_Price AS Unit_Price " +
                    "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                    "Product ON [Order].P_ID = Product.P_ID) " +
                    "WHERE (MONTH(Sales.S_Date) = @selectedMonth) AND (YEAR(Sales.S_Date) = @selectedYear)";
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
    }
}
