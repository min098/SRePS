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
    public partial class frmVisualize : Form
    {
        public frmVisualize()
        {
            InitializeComponent();
        }

        private void frmVisualize_Load(object sender, EventArgs e)
        {
            linegraph.SizeMode = PictureBoxSizeMode.StretchImage;
            barchart.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void linegraph_Click_1(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmVRev) == true)
            {

                Program.frmVRev.Focus();

            }
            else
            {
                Program.frmVRev = new frmVRevenue();
                Program.frmVRev.Show();

                //close the frmVisualize
                if (Program.isOpened(Program.frmV) == true)
                {
                    Program.frmV.Close();
                }
            }



        }

        private void barchart_Click_1(object sender, EventArgs e)
        {
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
            if (pickedSMonthYear == pickedEMonthYear)
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

                //close the frmVisualize
                if (Program.isOpened(Program.frmV) == true)
                {

                    Program.frmV.Close();

                }
            }
            else
            {
                MessageBox.Show("Only can generate visualization for top sales item group in same month." + "\n" + "Please select Visualization for Revenue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
