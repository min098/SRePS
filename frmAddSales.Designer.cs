namespace SRePS
{
    partial class frmAddSales
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
            System.Windows.Forms.Label lblBarcode;
            System.Windows.Forms.Label lblQuantity;
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.lblInv_No = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            lblBarcode = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBarcode.Location = new System.Drawing.Point(62, 101);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new System.Drawing.Size(77, 20);
            lblBarcode.TabIndex = 5;
            lblBarcode.Text = "Barcode:";
            lblBarcode.Click += new System.EventHandler(this.lblBarcode_Click);
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQuantity.Location = new System.Drawing.Point(62, 145);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(76, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(161, 99);
            this.barcodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(374, 27);
            this.barcodeTextBox.TabIndex = 6;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(161, 142);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(374, 27);
            this.quantityTextBox.TabIndex = 8;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(855, 303);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(149, 41);
            this.btnAddItem.TabIndex = 21;
            this.btnAddItem.Text = "&Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(855, 406);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 41);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(855, 354);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 41);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(692, 461);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 41);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "C&onfirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(532, 461);
            this.btnManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(149, 41);
            this.btnManage.TabIndex = 25;
            this.btnManage.Text = "&Manage Sales";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Location = new System.Drawing.Point(66, 188);
            this.itemGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowTemplate.Height = 24;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(775, 258);
            this.itemGrid.TabIndex = 26;
            this.itemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGrid_CellContentClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sRePS_DatabaseDataSet;
            // 
            // sRePS_DatabaseDataSet
            // 
            this.sRePS_DatabaseDataSet.DataSetName = "SRePS_DatabaseDataSet";
            this.sRePS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // lblInv_No
            // 
            this.lblInv_No.AutoSize = true;
            this.lblInv_No.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblInv_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv_No.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInv_No.Location = new System.Drawing.Point(181, 11);
            this.lblInv_No.Name = "lblInv_No";
            this.lblInv_No.Size = new System.Drawing.Size(103, 38);
            this.lblInv_No.TabIndex = 27;
            this.lblInv_No.Text = "label1";
            this.lblInv_No.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInv
            // 
            this.lblInv.AutoSize = true;
            this.lblInv.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInv.Location = new System.Drawing.Point(21, 11);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(129, 38);
            this.lblInv.TabIndex = 28;
            this.lblInv.Text = "Inv_No:";
            this.lblInv.Click += new System.EventHandler(this.label1_Click);
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
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1067, 28);
            this.menuBar.TabIndex = 29;
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
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
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportToolStripMenuItem_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.predictionToolStripMenuItem.Text = "Prediction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblInv_No);
            this.panel1.Controls.Add(this.lblInv);
            this.panel1.Location = new System.Drawing.Point(550, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 70);
            this.panel1.TabIndex = 31;
            // 
            // frmAddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(lblBarcode);
            this.Controls.Add(this.barcodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSalesFamily Aid Pharmacy Inc. SRePS - Add Sales";
            this.Load += new System.EventHandler(this.frmAddSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnManage;
        public System.Windows.Forms.DataGridView itemGrid;
        public SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        public System.Windows.Forms.BindingSource productBindingSource;
        public SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public System.Windows.Forms.Label lblInv_No;
        public System.Windows.Forms.Label lblInv;
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
        private System.Windows.Forms.Panel panel1;
    }
}