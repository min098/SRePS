using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRePS
{
    public partial class frmVRevenue : Form
    {
        public frmVRevenue()
        {
            InitializeComponent();
        }

        private void frmVRevenue_Load(object sender, EventArgs e)
        {
            generateChart();
        }

        public void generateChart()
        {
            string monthyear = String.Empty;
            try
            {
                for (int i = 0; i < Program.frmSalesM.salesReportMDataGridView.Rows.Count; i++)
                {
                    monthyear = Program.frmSalesM.salesReportMDataGridView.Rows[i].Cells[0].Value + "/" + Program.frmSalesM.salesReportMDataGridView.Rows[i].Cells[1].Value;
                    chartRevenue.Series["Revenue"].Points.AddXY(monthyear, Program.frmSalesM.salesReportMDataGridView.Rows[i].Cells[2].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to visualize due to " + ex.Message);
            }
        }

        private void frmVRevenue_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
