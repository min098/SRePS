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

        //temporarily link to homepage
        //need to validate account availability 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            conn.Open();
            OleDbDataReader read;
            string my_query = "SELECT * FROM Employees WHERE [E_ID]=? AND [E_Password]=?";
            OleDbCommand cmd = new OleDbCommand(my_query, conn);
            cmd.Parameters.AddWithValue("E_ID", UserNameTextBox.Text);
            cmd.Parameters.AddWithValue("E_Password", PasswordTextBox.Text);

            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Program.curUserName = read["E_ID"].ToString();
                Program.curPassword = read["E_Password"].ToString();
                Program.curName = read["E_Name"].ToString();
                Program.curPosition = read["E_Position"].ToString();
                Program.frmHome = new frmHomepage();
                Program.frmHome.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
