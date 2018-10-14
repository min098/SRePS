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
    public partial class frmProductManagement : Form
    {
        bool rowSeleted = false;
        int rowIndex = -1;
        string deletingPid;

        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void productManagement_Load(object sender, EventArgs e)
        {

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.sRePS_DatabaseDataSet.Order);
            // TODO: This line of code loads data into the 'sRePS_DatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sRePS_DatabaseDataSet.Product);

        }

        private void addProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource2.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sRePS_DatabaseDataSet);
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void p_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmAddP) == true)
            {

                Program.frmAddP.Focus();

            }
            else
            {
                Program.frmAddP = new frmAddProduct();
                Program.frmAddP.Show();
            }
        }

        private void productDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowSeleted = true;
            rowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowSeleted == true)
            {
                //Get the deleted row P_ID
                deletingPid = productDataGridView.Rows[rowIndex].Cells[0].Value.ToString();

                DataRow[] foundPID = sRePS_DatabaseDataSet.Order.Select("P_ID = '" + deletingPid + "'");
                //Check if the deleting product is existing in the Order table
                if (foundPID.Length != 0)
                {
                    MessageBox.Show("This record cannot be deleted as this product sold before", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //Pop up confirmation box
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Deleting record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.sRePS_DatabaseDataSet.Product.Rows[rowIndex].Delete();
                        productTableAdapter.Update(sRePS_DatabaseDataSet);
                        rowSeleted = false;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void frmProductManagement_FormClosing(object sender, FormClosingEventArgs e)
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
                Program.frmProduct.Dispose();

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

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (Program.isOpened(Program.frmEditP) == true)
            {

                Program.frmEditP.Focus();

            }
            else
            {
                Program.frmEditP = new frmEditProduct();
                Program.frmEditP.Show();
            }
        }
    }
}
