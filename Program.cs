using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRePS
{
    static class Program
    {
        public static frmAddProduct frmAddP;
        public static frmEditEmployee frmEditE;
        public static frmEditProduct frmEditP;
        public static frmEditSales frmEditS;
        public static frmEmployeeManagement frmEmployee;
        public static frmHomepage frmHome;
        public static frmLogIn frmLogin;
        public static frmProductManagement frmProduct;
        public static frmRegister frmRegister;
        public static frmSalesManagement frmSales;
        public static frmSalesReport frmSalesReport;
        public static frmSalesReportD frmSalesD;
        public static frmSalesReportM frmSalesM;
        public static frmSalesReportW frmSalesW;
        public static frmVRevenue frmVRev;
        public static frmAddSales frmAddS;
        public static frmPayment frmP;
        public static frmVTop frmTS;

        //stores current account information
        public static string curUserName = "";
        public static string curPassword = "";
        public static string curName = "";
        public static string curPosition = "";
        public static string curStatus = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //temporary
            var Login = new frmLogIn();
            Login.Show();
            Application.Run();
        }

        //check is form open
        public static bool isOpened(Form name)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
