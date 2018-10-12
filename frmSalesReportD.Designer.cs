namespace SRePS
{
    partial class frmSalesReportD
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.salesReportDDataGridView = new System.Windows.Forms.DataGridView();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter();
            this.sDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
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
            this.menuBar.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuBar.Size = new System.Drawing.Size(1200, 35);
            this.menuBar.TabIndex = 3;
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.weeklyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.predictionToolStripMenuItem.Text = "Prediction";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(18, 65);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(87, 62);
            this.dtpicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(298, 26);
            this.dtpicker.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(410, 60);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // salesReportDDataGridView
            // 
            this.salesReportDDataGridView.AllowUserToAddRows = false;
            this.salesReportDDataGridView.AllowUserToDeleteRows = false;
            this.salesReportDDataGridView.AutoGenerateColumns = false;
            this.salesReportDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesReportDDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.salesReportDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDateDataGridViewTextBoxColumn,
            this.invNoDataGridViewTextBoxColumn});
            this.salesReportDDataGridView.DataSource = this.salesBindingSource;
            this.salesReportDDataGridView.Location = new System.Drawing.Point(12, 123);
            this.salesReportDDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salesReportDDataGridView.Name = "salesReportDDataGridView";
            this.salesReportDDataGridView.ReadOnly = true;
            this.salesReportDDataGridView.Size = new System.Drawing.Size(1176, 418);
            this.salesReportDDataGridView.TabIndex = 7;
            // 
            // btnVisualize
            // 
            this.btnVisualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualize.Location = new System.Drawing.Point(933, 618);
            this.btnVisualize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(112, 35);
            this.btnVisualize.TabIndex = 6;
            this.btnVisualize.Text = "&Visualize";
            this.btnVisualize.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(1076, 618);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 35);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // sRePS_DatabaseDataSet
            // 
            this.sRePS_DatabaseDataSet.DataSetName = "SRePS_DatabaseDataSet";
            this.sRePS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // sDateDataGridViewTextBoxColumn
            // 
            this.sDateDataGridViewTextBoxColumn.DataPropertyName = "S_Date";
            this.sDateDataGridViewTextBoxColumn.HeaderText = "S_Date";
            this.sDateDataGridViewTextBoxColumn.Name = "sDateDataGridViewTextBoxColumn";
            this.sDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invNoDataGridViewTextBoxColumn
            // 
            this.invNoDataGridViewTextBoxColumn.DataPropertyName = "Inv_No";
            this.invNoDataGridViewTextBoxColumn.HeaderText = "Inv_No";
            this.invNoDataGridViewTextBoxColumn.Name = "invNoDataGridViewTextBoxColumn";
            this.invNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSalesReportD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.salesReportDDataGridView);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.menuBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSalesReportD";
            this.Text = "Family Aid Pharmacy Inc. SRePS";
            this.Load += new System.EventHandler(this.frmSalesReportD_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView salesReportDDataGridView;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.Button btnExport;
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNoDataGridViewTextBoxColumn;
    }
}