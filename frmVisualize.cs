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
            if (Program.frmSalesM.dtpickerStart.Text != Program.frmSalesM.dtpickerEnd.Text) //only display graph when there is range between picked start date and end date
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
            else
            {
                MessageBox.Show("Only can generate visualization for revenue for different month." + "\n" + "Please change your start date and end date with range in between.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmVisualize_FormClosing(object sender, FormClosingEventArgs e)
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
