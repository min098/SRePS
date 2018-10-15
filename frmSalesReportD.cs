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

        }

        private void frmSalesReportD_FormClosing(object sender, FormClosingEventArgs e)
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

                string query = "SELECT Sales.S_Date, [Order].Inv_No, SUM(Product.P_Price*[Order].S_Quantity) AS Total " +
                    "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN " +
                    "Product ON [Order].P_ID = Product.P_ID) " +
                    "WHERE Sales.S_Date = @S_Date " +
                    "GROUP BY Sales.S_Date, [Order].Inv_No";
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
    }
}
