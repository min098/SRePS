namespace SRePS
{
    partial class frmSalesManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesManagement));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.sDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditSales = new System.Windows.Forms.Button();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBtnBack = new System.Windows.Forms.ToolStripButton();
            this.salesOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesOrderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.OrderTableAdapter();
            this.salesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter();
            this.salesManagementTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.SalesManagementTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesMngDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMngDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.predictionToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(802, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_ItemClicked);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.weeklyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportToolStripMenuItem_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.predictionToolStripMenuItem.Text = "Prediction";
            this.predictionToolStripMenuItem.Click += new System.EventHandler(this.predictionToolStripMenuItem_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDateDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.invNoDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.salesDataGridView.DataSource = this.salesManagementBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(10, 33);
            this.salesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesDataGridView.MultiSelect = false;
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(784, 288);
            this.salesDataGridView.TabIndex = 2;
            this.salesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sDateDataGridViewTextBoxColumn
            // 
            this.sDateDataGridViewTextBoxColumn.DataPropertyName = "S_Date";
            this.sDateDataGridViewTextBoxColumn.HeaderText = "S_Date";
            this.sDateDataGridViewTextBoxColumn.Name = "sDateDataGridViewTextBoxColumn";
            this.sDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "Invoice";
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            this.invoiceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invNoDataGridViewTextBoxColumn
            // 
            this.invNoDataGridViewTextBoxColumn.DataPropertyName = "Inv_No";
            this.invNoDataGridViewTextBoxColumn.HeaderText = "Inv_No";
            this.invNoDataGridViewTextBoxColumn.Name = "invNoDataGridViewTextBoxColumn";
            this.invNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "E_ID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "E_ID";
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesManagementBindingSource
            // 
            this.salesManagementBindingSource.DataMember = "SalesManagement";
            this.salesManagementBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // sRePS_DatabaseDataSet
            // 
            this.sRePS_DatabaseDataSet.DataSetName = "SRePS_DatabaseDataSet";
            this.sRePS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(456, 405);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditSales
            // 
            this.btnEditSales.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSales.Location = new System.Drawing.Point(338, 405);
            this.btnEditSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditSales.Name = "btnEditSales";
            this.btnEditSales.Size = new System.Drawing.Size(112, 33);
            this.btnEditSales.TabIndex = 7;
            this.btnEditSales.Text = "&Edit";
            this.btnEditSales.UseVisualStyleBackColor = false;
            this.btnEditSales.Click += new System.EventHandler(this.btnEditSales_Click);
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSales.Location = new System.Drawing.Point(220, 405);
            this.btnAddSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(112, 33);
            this.btnAddSales.TabIndex = 6;
            this.btnAddSales.Text = "&Add New";
            this.btnAddSales.UseVisualStyleBackColor = false;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = null;
            this.productBindingNavigator.CountItem = null;
            this.productBindingNavigator.DeleteItem = null;
            this.productBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.productBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBack});
            this.productBindingNavigator.Location = new System.Drawing.Point(10, 322);
            this.productBindingNavigator.MoveFirstItem = null;
            this.productBindingNavigator.MoveLastItem = null;
            this.productBindingNavigator.MoveNextItem = null;
            this.productBindingNavigator.MovePreviousItem = null;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.productBindingNavigator.PositionItem = null;
            this.productBindingNavigator.Size = new System.Drawing.Size(91, 27);
            this.productBindingNavigator.TabIndex = 9;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripBtnBack
            // 
            this.toolStripBtnBack.AutoSize = false;
            this.toolStripBtnBack.AutoToolTip = false;
            this.toolStripBtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBack.Image")));
            this.toolStripBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBack.Name = "toolStripBtnBack";
            this.toolStripBtnBack.Size = new System.Drawing.Size(56, 24);
            this.toolStripBtnBack.Text = "Back";
            this.toolStripBtnBack.Click += new System.EventHandler(this.toolStripBtnBack_Click);
            // 
            // salesOrderBindingSource1
            // 
            this.salesOrderBindingSource1.DataMember = "SalesOrder";
            // 
            // salesOrderBindingSource2
            // 
            this.salesOrderBindingSource2.DataMember = "SalesOrder";
            // 
            // salesBindingSource3
            // 
            this.salesBindingSource3.DataMember = "Sales";
            this.salesBindingSource3.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // salesOrderBindingSource
            // 
            this.salesOrderBindingSource.DataMember = "SalesOrder";
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesManagementTableAdapter
            // 
            this.salesManagementTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.UpdateOrder = SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // salesMngDetailDataGridView
            // 
            this.salesMngDetailDataGridView.AllowUserToAddRows = false;
            this.salesMngDetailDataGridView.AllowUserToDeleteRows = false;
            this.salesMngDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salesMngDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesMngDetailDataGridView.Location = new System.Drawing.Point(10, 33);
            this.salesMngDetailDataGridView.MultiSelect = false;
            this.salesMngDetailDataGridView.Name = "salesMngDetailDataGridView";
            this.salesMngDetailDataGridView.ReadOnly = true;
            this.salesMngDetailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesMngDetailDataGridView.Size = new System.Drawing.Size(784, 288);
            this.salesMngDetailDataGridView.TabIndex = 10;
            this.salesMngDetailDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.salesMngDetailDataGridView_RowHeaderMouseClick);
            // 
            // frmSalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.salesMngDetailDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditSales);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.productBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSalesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Sales Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesManagement_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMngDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
        public System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditSales;
        private System.Windows.Forms.Button btnAddSales;
        public SRePS_DatabaseDataSet sRePS_DatabaseDataSet; //NOTE: changed to public
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private SRePS_DatabaseDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource3;
        private System.Windows.Forms.BindingSource salesOrderBindingSource1;
        private System.Windows.Forms.BindingSource salesOrderBindingSource2;
        private System.Windows.Forms.BindingSource salesOrderBindingSource;
        public SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesManagementBindingSource;
        public SRePS_DatabaseDataSetTableAdapters.SalesManagementTableAdapter salesManagementTableAdapter; //NOTE: changed to public
        private System.Windows.Forms.BindingSource productBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SRePS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SRePS_DatabaseDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripBtnBack;
        public System.Windows.Forms.DataGridView salesMngDetailDataGridView;   //NOTE: changed to public
        private System.Windows.Forms.DataGridViewTextBoxColumn sDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}