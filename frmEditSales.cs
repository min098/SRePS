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
    public partial class frmEditSales : Form
    {
        public frmEditSales()
        {
            InitializeComponent();
        }

        private void frmEditSales_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string oldInvNo = Program.frmSales.salesMngDetailDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string oldEID = Program.frmSales.salesMngDetailDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string oldPID = Program.frmSales.salesMngDetailDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string oldQtySold = Program.frmSales.salesMngDetailDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = SRePS.Properties.Settings.Default.SRePS_DatabaseConnectionString;

            if (txtSalesDate.Text == "" || txtEID.Text == "" || txtPID.Text == "" || txtSQty.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    string query1 = "UPDATE [Sales] SET [S_Date]=?, [E_ID]=? WHERE [Inv_No]=?";
                    OleDbCommand cmd = new OleDbCommand(query1, conn);
                    cmd.Parameters.AddWithValue("S_Date", txtSalesDate.Text);

                    //must include the employeesBindingSource in frmSalesManagement to have the data of the Employees table
                    DataRow[] foundEID = Program.frmSales.sRePS_DatabaseDataSet.Employees.Select("E_ID = '" + txtEID.Text + "'");
                    if (foundEID.Count() != 0)   //E_ID exists in Employees table
                    {
                        cmd.Parameters.AddWithValue("E_ID", txtEID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter an existing Employee ID");
                    }

                    cmd.Parameters.AddWithValue("Inv_No", oldInvNo);
                    cmd.ExecuteNonQuery();


                    string query2 = "UPDATE [Order] SET [P_ID]=?, [S_Quantity]=? WHERE [Inv_No]=? AND [P_ID]=?";
                    OleDbCommand cmd2 = new OleDbCommand(query2, conn);
                    //must include the productBindingSource in frmSalesManagement to have the data of the Product table
                    DataRow[] foundPID = Program.frmSales.sRePS_DatabaseDataSet.Product.Select("P_ID = '" + txtPID.Text + "'");
                    if (foundPID.Length != 0)   //P_ID exists in Product table
                    {
                        cmd2.Parameters.AddWithValue("P_ID", txtPID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter an existing Product ID");
                    }

                    cmd2.Parameters.AddWithValue("S_Quantity", txtSQty.Text);
                    cmd2.Parameters.AddWithValue("Inv_No", oldInvNo);
                    cmd2.Parameters.AddWithValue("P_ID", oldPID);
                    cmd2.ExecuteNonQuery();


                    int quantityChanged = 0;
                    if (txtPID.Text == oldPID)
                    {
                        if (txtSQty.Text != oldQtySold)
                        {
                            quantityChanged = Convert.ToInt32(txtSQty.Text) - Convert.ToInt32(oldQtySold);

                            string query3 = "UPDATE [Product] SET [P_Quantity]=P_Quantity-@quantityChanged WHERE [P_ID]=?";
                            OleDbCommand cmd3 = new OleDbCommand(query3, conn);
                            cmd3.Parameters.AddWithValue("@quantityChanged", quantityChanged);
                            cmd3.Parameters.AddWithValue("P_ID", txtPID.Text);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        quantityChanged = Convert.ToInt32(txtSQty.Text);
                        //add the quantity back to the old PID
                        string query3 = "UPDATE [Product] SET [P_Quantity]=P_Quantity+@quantityChanged WHERE [P_ID]=?";
                        OleDbCommand cmd3 = new OleDbCommand(query3, conn);
                        cmd3.Parameters.AddWithValue("@quantityChanged", quantityChanged);
                        cmd3.Parameters.AddWithValue("P_ID", oldPID);
                        cmd3.ExecuteNonQuery();
                        cmd3.Parameters.Clear();

                        //then substract quantity from the new PID
                        query3 = "UPDATE [Product] SET [P_Quantity]=P_Quantity-@quantityChanged WHERE [P_ID]=?";
                        cmd3 = new OleDbCommand(query3, conn);
                        cmd3.Parameters.AddWithValue("@quantityChanged", quantityChanged);
                        cmd3.Parameters.AddWithValue("P_ID", txtPID.Text);
                        cmd3.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sales record edited successfully!");

                    if (Program.frmSales.sRePS_DatabaseDataSet.Tables["SalesManagementDetail"] != null)
                    {
                        Program.frmSales.sRePS_DatabaseDataSet.Tables["SalesManagementDetail"].Clear();
                    }

                    //update the salesMngDetailDataGrid
                    Program.frmSales.salesMngDetailAdapter.Fill(Program.frmSales.sRePS_DatabaseDataSet, "SalesManagementDetail");

                    //update the salesManagementDataGrid
                    Program.frmSales.salesManagementTableAdapter.Fill(Program.frmSales.sRePS_DatabaseDataSet.SalesManagement);

                    this.Close();
                }
                catch (Exception)
                {
                    //MessageBox.Show("Failed to edit due to " + a.Message);
                }

                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmEditSales_FormClosing(object sender, FormClosingEventArgs e)
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
