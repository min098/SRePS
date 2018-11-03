namespace SRePS
{
    partial class frmAddProduct
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
            System.Windows.Forms.Label lblPID;
            System.Windows.Forms.Label lblPName;
            System.Windows.Forms.Label lblPQuantity;
            System.Windows.Forms.Label lblPPrice;
            System.Windows.Forms.Label lblPCost;
            System.Windows.Forms.Label lblPSupplier;
            System.Windows.Forms.Label lblPUOM;
            System.Windows.Forms.Label lblPGroup;
            System.Windows.Forms.Label label1;
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
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.p_NameTextBox = new System.Windows.Forms.TextBox();
            this.p_PriceTextBox = new System.Windows.Forms.TextBox();
            this.p_CostTextBox = new System.Windows.Forms.TextBox();
            this.p_SupplierTextBox = new System.Windows.Forms.TextBox();
            this.p_UOMComboBox = new System.Windows.Forms.ComboBox();
            this.p_GroupComboBox = new System.Windows.Forms.ComboBox();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.p_SubGroupComboBox = new System.Windows.Forms.ComboBox();
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.P_QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            lblPID = new System.Windows.Forms.Label();
            lblPName = new System.Windows.Forms.Label();
            lblPQuantity = new System.Windows.Forms.Label();
            lblPPrice = new System.Windows.Forms.Label();
            lblPCost = new System.Windows.Forms.Label();
            lblPSupplier = new System.Windows.Forms.Label();
            lblPUOM = new System.Windows.Forms.Label();
            lblPGroup = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_QuantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPID
            // 
            lblPID.AutoSize = true;
            lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPID.Location = new System.Drawing.Point(245, 76);
            lblPID.Name = "lblPID";
            lblPID.Size = new System.Drawing.Size(94, 20);
            lblPID.TabIndex = 3;
            lblPID.Text = "Product ID:";
            lblPID.Click += new System.EventHandler(this.p_IDLabel_Click);
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPName.Location = new System.Drawing.Point(245, 121);
            lblPName.Name = "lblPName";
            lblPName.Size = new System.Drawing.Size(121, 20);
            lblPName.TabIndex = 4;
            lblPName.Text = "Product Name:";
            // 
            // lblPQuantity
            // 
            lblPQuantity.AutoSize = true;
            lblPQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPQuantity.Location = new System.Drawing.Point(245, 336);
            lblPQuantity.Name = "lblPQuantity";
            lblPQuantity.Size = new System.Drawing.Size(139, 20);
            lblPQuantity.TabIndex = 6;
            lblPQuantity.Text = "Product Quantity:";
            lblPQuantity.Click += new System.EventHandler(this.p_QuantityLabel_Click);
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPPrice.Location = new System.Drawing.Point(245, 166);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new System.Drawing.Size(116, 20);
            lblPPrice.TabIndex = 8;
            lblPPrice.Text = "Product Price:";
            lblPPrice.Click += new System.EventHandler(this.p_PriceLabel_Click);
            // 
            // lblPCost
            // 
            lblPCost.AutoSize = true;
            lblPCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPCost.Location = new System.Drawing.Point(245, 209);
            lblPCost.Name = "lblPCost";
            lblPCost.Size = new System.Drawing.Size(112, 20);
            lblPCost.TabIndex = 10;
            lblPCost.Text = "Product Cost:";
            lblPCost.Click += new System.EventHandler(this.lblPCost_Click);
            // 
            // lblPSupplier
            // 
            lblPSupplier.AutoSize = true;
            lblPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPSupplier.Location = new System.Drawing.Point(245, 251);
            lblPSupplier.Name = "lblPSupplier";
            lblPSupplier.Size = new System.Drawing.Size(138, 20);
            lblPSupplier.TabIndex = 12;
            lblPSupplier.Text = "Product Supplier:";
            lblPSupplier.Click += new System.EventHandler(this.p_SupplierLabel_Click);
            // 
            // lblPUOM
            // 
            lblPUOM.AutoSize = true;
            lblPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPUOM.Location = new System.Drawing.Point(245, 296);
            lblPUOM.Name = "lblPUOM";
            lblPUOM.Size = new System.Drawing.Size(116, 20);
            lblPUOM.TabIndex = 14;
            lblPUOM.Text = "Product UOM:";
            // 
            // lblPGroup
            // 
            lblPGroup.AutoSize = true;
            lblPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPGroup.Location = new System.Drawing.Point(245, 380);
            lblPGroup.Name = "lblPGroup";
            lblPGroup.Size = new System.Drawing.Size(123, 20);
            lblPGroup.TabIndex = 16;
            lblPGroup.Text = "Product Group:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(245, 421);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 20);
            label1.TabIndex = 25;
            label1.Text = "Product Sub-Group:";
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
            this.menuBar.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuBar.Size = new System.Drawing.Size(1067, 26);
            this.menuBar.TabIndex = 2;
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
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_ID", true));
            this.p_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_IDTextBox.Location = new System.Drawing.Point(445, 73);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(371, 27);
            this.p_IDTextBox.TabIndex = 4;
            this.p_IDTextBox.TextChanged += new System.EventHandler(this.p_IDTextBox_TextChanged);
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
            // p_NameTextBox
            // 
            this.p_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Name", true));
            this.p_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_NameTextBox.Location = new System.Drawing.Point(445, 118);
            this.p_NameTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_NameTextBox.Name = "p_NameTextBox";
            this.p_NameTextBox.Size = new System.Drawing.Size(371, 27);
            this.p_NameTextBox.TabIndex = 5;
            // 
            // p_PriceTextBox
            // 
            this.p_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Price", true));
            this.p_PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PriceTextBox.Location = new System.Drawing.Point(445, 161);
            this.p_PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_PriceTextBox.Name = "p_PriceTextBox";
            this.p_PriceTextBox.Size = new System.Drawing.Size(371, 27);
            this.p_PriceTextBox.TabIndex = 9;
            this.p_PriceTextBox.TextChanged += new System.EventHandler(this.p_PriceTextBox_TextChanged);
            // 
            // p_CostTextBox
            // 
            this.p_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Cost", true));
            this.p_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_CostTextBox.Location = new System.Drawing.Point(445, 205);
            this.p_CostTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_CostTextBox.Name = "p_CostTextBox";
            this.p_CostTextBox.Size = new System.Drawing.Size(371, 27);
            this.p_CostTextBox.TabIndex = 11;
            // 
            // p_SupplierTextBox
            // 
            this.p_SupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Supplier", true));
            this.p_SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SupplierTextBox.Location = new System.Drawing.Point(445, 248);
            this.p_SupplierTextBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_SupplierTextBox.Name = "p_SupplierTextBox";
            this.p_SupplierTextBox.Size = new System.Drawing.Size(371, 27);
            this.p_SupplierTextBox.TabIndex = 13;
            // 
            // p_UOMComboBox
            // 
            this.p_UOMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_UOMComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_UOMComboBox.FormattingEnabled = true;
            this.p_UOMComboBox.Items.AddRange(new object[] {
            "Bottle",
            "Dozen",
            "Gram",
            "Pcs",
            "Tablet"});
            this.p_UOMComboBox.Location = new System.Drawing.Point(445, 292);
            this.p_UOMComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_UOMComboBox.Name = "p_UOMComboBox";
            this.p_UOMComboBox.Size = new System.Drawing.Size(371, 28);
            this.p_UOMComboBox.TabIndex = 17;
            this.p_UOMComboBox.SelectedIndexChanged += new System.EventHandler(this.p_UOMComboBox_SelectedIndexChanged);
            // 
            // p_GroupComboBox
            // 
            this.p_GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_GroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_GroupComboBox.FormattingEnabled = true;
            this.p_GroupComboBox.Items.AddRange(new object[] {
            "--Select the main group of product--",
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.p_GroupComboBox.Location = new System.Drawing.Point(445, 377);
            this.p_GroupComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_GroupComboBox.Name = "p_GroupComboBox";
            this.p_GroupComboBox.Size = new System.Drawing.Size(371, 28);
            this.p_GroupComboBox.Sorted = true;
            this.p_GroupComboBox.TabIndex = 18;
            this.p_GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.p_GroupComboBox_SelectedIndexChanged);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(547, 473);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(149, 41);
            this.btnCancelProduct.TabIndex = 21;
            this.btnCancelProduct.Text = "&Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = false;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(392, 473);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 41);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "&Add New";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // p_SubGroupComboBox
            // 
            this.p_SubGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p_SubGroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SubGroupComboBox.FormattingEnabled = true;
            this.p_SubGroupComboBox.Items.AddRange(new object[] {
            "--Select the sub group of product--"});
            this.p_SubGroupComboBox.Location = new System.Drawing.Point(445, 417);
            this.p_SubGroupComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.p_SubGroupComboBox.Name = "p_SubGroupComboBox";
            this.p_SubGroupComboBox.Size = new System.Drawing.Size(371, 28);
            this.p_SubGroupComboBox.Sorted = true;
            this.p_SubGroupComboBox.TabIndex = 26;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // P_QuantityUpDown
            // 
            this.P_QuantityUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_QuantityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_QuantityUpDown.Location = new System.Drawing.Point(445, 334);
            this.P_QuantityUpDown.Name = "P_QuantityUpDown";
            this.P_QuantityUpDown.Size = new System.Drawing.Size(371, 27);
            this.P_QuantityUpDown.TabIndex = 7;
            this.P_QuantityUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.P_QuantityUpDown);
            this.Controls.Add(this.p_SubGroupComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.p_GroupComboBox);
            this.Controls.Add(this.p_UOMComboBox);
            this.Controls.Add(lblPGroup);
            this.Controls.Add(lblPUOM);
            this.Controls.Add(lblPSupplier);
            this.Controls.Add(this.p_SupplierTextBox);
            this.Controls.Add(lblPCost);
            this.Controls.Add(this.p_CostTextBox);
            this.Controls.Add(lblPPrice);
            this.Controls.Add(this.p_PriceTextBox);
            this.Controls.Add(lblPQuantity);
            this.Controls.Add(lblPName);
            this.Controls.Add(this.p_NameTextBox);
            this.Controls.Add(lblPID);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.menuBar);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_QuantityUpDown)).EndInit();
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
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SRePS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox p_NameTextBox;
        private System.Windows.Forms.TextBox p_PriceTextBox;
        private System.Windows.Forms.TextBox p_CostTextBox;
        private System.Windows.Forms.TextBox p_SupplierTextBox;
        private System.Windows.Forms.ComboBox p_GroupComboBox;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox p_UOMComboBox;
        private System.Windows.Forms.ComboBox p_SubGroupComboBox;
        private System.Windows.Forms.NumericUpDown P_QuantityUpDown;
    }
}