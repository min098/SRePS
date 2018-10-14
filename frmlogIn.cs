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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                Program.frmRegister = new frmRegister();
                Program.frmRegister.Show();
                //temporary
                this.Dispose();
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //temporarily link to homepage
        //need to validate account availability 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmHome) == true)
            {

                Program.frmHome.Show();
                this.Dispose();

            }
            else
            {
                Program.frmHome = new frmHomepage();
                Program.frmHome.Show();
                //temporary
                this.Dispose();
            }
        }
    }
}
