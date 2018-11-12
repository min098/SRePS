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
    public partial class frmVTop : Form
    {
        public frmVTop()
        {
            InitializeComponent();
        }

        private void frmVTop_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.sRePS_DatabaseDataSet.Order);
            TopSalesChart.Visible = false;
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            TopSalesChart.Series["P_SubGroup"].Points.Clear();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
            con.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            //startDate
            string pickedSMonthYear = Program.frmSalesM.dtpickerStart.Text;
            string[] splitSMonthYear = pickedSMonthYear.Split(' ');
            string pickedSMonth = splitSMonthYear[0];
            string pickedSYear = splitSMonthYear[1];
            string pickedSDate = "1/" + Program.frmSalesM.monthDictionary(pickedSMonth) + "/" + pickedSYear;

            //endDate
            string pickedEMonthYear = Program.frmSalesM.dtpickerEnd.Text;
            string[] splitEMonthYear = pickedEMonthYear.Split(' ');
            string pickedEMonth = splitEMonthYear[0];
            string pickedEYear = splitEMonthYear[1];
            int endofmonth = DateTime.DaysInMonth(Convert.ToInt32(pickedEYear), Convert.ToInt32(Program.frmSalesM.monthDictionary(pickedEMonth)));
            string pickedEDate = endofmonth.ToString() + "/" + pickedEMonth + "/" + pickedEYear;

            con.Open();
            if (GroupComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select Product Group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "SELECT Product.P_SubGroup As SubGroup, SUM(Order.S_Quantity) AS Quantity " +
                                    "FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No) INNER JOIN Product ON [Order].P_ID = Product.P_ID) " +
                                    "WHERE (Sales.S_Date >= @startdate) AND (Sales.S_Date <= @endDate)  AND (((Product.P_Group) = @Group)) " +
                                    "GROUP BY YEAR(Sales.S_Date), MONTH(Sales.S_Date), Product.P_SubGroup ";

                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@startdate", pickedSDate);
                    cmd.Parameters.AddWithValue("@endDate", pickedEDate);
                    cmd.Parameters.AddWithValue("@Group", GroupComboBox.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();


                    if (!reader.HasRows)
                    {
                        MessageBox.Show("There is no sales for this product group in this month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        while (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TopSalesChart.Visible = true;
                                TopSalesChart.Series["P_SubGroup"].Points.AddXY(reader.GetValue(0), reader.GetValue(1));
                            }
                                reader.NextResult();
                         }
                     }
                }
                catch (Exception)
                {
                    throw;

                }
                con.Close();
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
    
