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
            }
        }

        private void barchart_Click_1(object sender, EventArgs e)
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
}
