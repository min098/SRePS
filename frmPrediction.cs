using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SRePS
{
    public partial class frmPrediction : Form
    {
        public frmPrediction()
        {
            InitializeComponent();
        }

        private void frmPrediction_Load(object sender, EventArgs e)
        {
            chartPredict.Visible = false;
        }

        private void frmPrediction_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex == 0) //equipment
            {

                cmbSubGroup.Items.Clear();
                cmbSubGroup.Enabled = true;
                cmbSubGroup.Items.Add("Incontinence");
                cmbSubGroup.Items.Add("Orthopedic");
                cmbSubGroup.Items.Add("Walking Aids");
                cmbSubGroup.Items.Add("Wheelchairs");
                cmbSubGroup.Items.Add("Wound Care");



            }
            else if (cmbGroup.SelectedIndex == 1) //healthcare
            {
                cmbSubGroup.Items.Clear();
                cmbSubGroup.Enabled = true;
                cmbSubGroup.Items.Add("Cod Liver Oil");
                cmbSubGroup.Items.Add("Chicken Essence");
                cmbSubGroup.Items.Add("Diet");
                cmbSubGroup.Items.Add("Fish Essence");
                cmbSubGroup.Items.Add("Spirulina");
                cmbSubGroup.Items.Add("Vitamin");

            }
            else if (cmbGroup.SelectedIndex == 2) //medicine
            {
                cmbSubGroup.Items.Clear();
                cmbSubGroup.Enabled = true;
                cmbSubGroup.Items.Add("Allergic");
                cmbSubGroup.Items.Add("Birth Control");
                cmbSubGroup.Items.Add("Central Nervous System");
                cmbSubGroup.Items.Add("Circulatory System");
                cmbSubGroup.Items.Add("Cough");
                cmbSubGroup.Items.Add("Digestive System");
                cmbSubGroup.Items.Add("Ear");
                cmbSubGroup.Items.Add("Eye");
                cmbSubGroup.Items.Add("Endocrine System");
                cmbSubGroup.Items.Add("Fever");
                cmbSubGroup.Items.Add("Immune System");
                cmbSubGroup.Items.Add("Menstrual Pain");
                cmbSubGroup.Items.Add("Musculoskeletal Disorders");
                cmbSubGroup.Items.Add("Nose");
                cmbSubGroup.Items.Add("Pain and Consciousness");
                cmbSubGroup.Items.Add("Reproductive System");
                cmbSubGroup.Items.Add("Respiratory System");
                cmbSubGroup.Items.Add("Throat");
                cmbSubGroup.Items.Add("Skin");
                cmbSubGroup.Items.Add("Urinary System");
            }
        }

        private void btnVisualize_Click(object sender, EventArgs e)
        {
            chartPredict.Series["This Month Sales"].Points.Clear();

            DateTime dt = DateTime.Now;
            int CurrYear = dt.Year;
            int NextMonth = dt.AddMonths(+1).Month;
            chartPredict.ChartAreas[0].AxisX.Minimum = 1;
            chartPredict.ChartAreas[0].AxisX.Maximum = 12;
            //chartPredict.ChartAreas[0].AxisX.IsMarginVisible = false;
         

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            conn.Open();

            string query = "SELECT MONTH(Sales.S_Date),SUM(Product.P_Price*[Order].S_Quantity) As Total FROM ((Sales INNER JOIN [Order] ON Sales.Inv_No = [Order].Inv_No)" +
                           "INNER JOIN Product ON [Order].P_ID = Product.P_ID)" +
                           "WHERE (YEAR(Sales.S_Date) = @curYear) AND (Product.P_SubGroup = @pGroup)" +
                           "GROUP BY MONTH(Sales.S_Date),Product.P_SubGroup";

            OleDbCommand cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@curYear", CurrYear);
            cmd.Parameters.AddWithValue("@pGroup", cmbSubGroup.SelectedItem.ToString());
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
                        chartPredict.Visible = true;
                        chartPredict.Series["This Month Sales"].Points.AddXY(reader.GetValue(0), reader.GetValue(1));
                        //MessageBox.Show(reader.GetValue(0).ToString());
                    }
                   
                    reader.NextResult();
            }
        }
            conn.Close();
        }

        private void chartPredict_Click(object sender, EventArgs e)
        {

        }
    }
}
