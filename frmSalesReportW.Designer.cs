namespace SRePS
{
    partial class frmSalesReportW
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
            this.salesReportWDataGridView = new System.Windows.Forms.DataGridView();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
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
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpickerEnd = new System.Windows.Forms.DateTimePicker();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter();
            this.salesDetailDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportWDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesReportWDataGridView
            // 
            this.salesReportWDataGridView.AllowUserToAddRows = false;
            this.salesReportWDataGridView.AllowUserToDeleteRows = false;
            this.salesReportWDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesReportWDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salesReportWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportWDataGridView.Location = new System.Drawing.Point(8, 80);
            this.salesReportWDataGridView.MultiSelect = false;
            this.salesReportWDataGridView.Name = "salesReportWDataGridView";
            this.salesReportWDataGridView.ReadOnly = true;
            this.salesReportWDataGridView.Size = new System.Drawing.Size(784, 272);
            this.salesReportWDataGridView.TabIndex = 12;
            this.salesReportWDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesReportWDataGridView_CellDoubleClick);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // sRePS_DatabaseDataSet
            // 
            this.sRePS_DatabaseDataSet.DataSetName = "SRePS_DatabaseDataSet";
            this.sRePS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(679, 405);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 33);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnVisualize
            // 
            this.btnVisualize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVisualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualize.Location = new System.Drawing.Point(561, 405);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(112, 33);
            this.btnVisualize.TabIndex = 13;
            this.btnVisualize.Text = "&Visualize";
            this.btnVisualize.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(508, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpickerStart
            // 
            this.dtpickerStart.CustomFormat = "dd/MM/yyyy dddd";
            this.dtpickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerStart.Location = new System.Drawing.Point(58, 40);
            this.dtpickerStart.Name = "dtpickerStart";
            this.dtpickerStart.Size = new System.Drawing.Size(200, 20);
            this.dtpickerStart.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
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
            this.menuBar.Size = new System.Drawing.Size(800, 24);
            this.menuBar.TabIndex = 14;
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
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(264, 42);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 16);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            // 
            // dtpickerEnd
            // 
            this.dtpickerEnd.CustomFormat = "dd/MM/yyyy dddd";
            this.dtpickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerEnd.Location = new System.Drawing.Point(295, 40);
            this.dtpickerEnd.Name = "dtpickerEnd";
            this.dtpickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpickerEnd.TabIndex = 10;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesDetailDataGridView
            // 
            this.salesDetailDataGridView.AllowUserToAddRows = false;
            this.salesDetailDataGridView.AllowUserToDeleteRows = false;
            this.salesDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDetailDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salesDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDetailDataGridView.Location = new System.Drawing.Point(8, 80);
            this.salesDetailDataGridView.MultiSelect = false;
            this.salesDetailDataGridView.Name = "salesDetailDataGridView";
            this.salesDetailDataGridView.ReadOnly = true;
            this.salesDetailDataGridView.Size = new System.Drawing.Size(784, 272);
            this.salesDetailDataGridView.TabIndex = 15;
            // 
            // frmSalesReportW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesDetailDataGridView);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.salesReportWDataGridView);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpickerEnd);
            this.Controls.Add(this.dtpickerStart);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblDate);
            this.Name = "frmSalesReportW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Weekly Sales Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesReportW_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesReportW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportWDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesReportWDataGridView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpickerStart;
        private System.Windows.Forms.Label lblDate;
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
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpickerEnd;
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridView salesDetailDataGridView;
        //private SRePS_DatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
    }
}