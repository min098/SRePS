﻿namespace SRePS
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
            this.p_QuantityTextBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // lblPID
            // 
            lblPID.AutoSize = true;
            lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPID.Location = new System.Drawing.Point(184, 62);
            lblPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPID.Name = "lblPID";
            lblPID.Size = new System.Drawing.Size(78, 17);
            lblPID.TabIndex = 3;
            lblPID.Text = "Product ID:";
            lblPID.Click += new System.EventHandler(this.p_IDLabel_Click);
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPName.Location = new System.Drawing.Point(184, 98);
            lblPName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPName.Name = "lblPName";
            lblPName.Size = new System.Drawing.Size(102, 17);
            lblPName.TabIndex = 4;
            lblPName.Text = "Product Name:";
            // 
            // lblPQuantity
            // 
            lblPQuantity.AutoSize = true;
            lblPQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPQuantity.Location = new System.Drawing.Point(184, 134);
            lblPQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPQuantity.Name = "lblPQuantity";
            lblPQuantity.Size = new System.Drawing.Size(118, 17);
            lblPQuantity.TabIndex = 6;
            lblPQuantity.Text = "Product Quantity:";
            lblPQuantity.Click += new System.EventHandler(this.p_QuantityLabel_Click);
            // 
            // lblPPrice
            // 
            lblPPrice.AutoSize = true;
            lblPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPPrice.Location = new System.Drawing.Point(184, 172);
            lblPPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPPrice.Name = "lblPPrice";
            lblPPrice.Size = new System.Drawing.Size(97, 17);
            lblPPrice.TabIndex = 8;
            lblPPrice.Text = "Product Price:";
            lblPPrice.Click += new System.EventHandler(this.p_PriceLabel_Click);
            // 
            // lblPCost
            // 
            lblPCost.AutoSize = true;
            lblPCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPCost.Location = new System.Drawing.Point(184, 207);
            lblPCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPCost.Name = "lblPCost";
            lblPCost.Size = new System.Drawing.Size(93, 17);
            lblPCost.TabIndex = 10;
            lblPCost.Text = "Product Cost:";
            lblPCost.Click += new System.EventHandler(this.lblPCost_Click);
            // 
            // lblPSupplier
            // 
            lblPSupplier.AutoSize = true;
            lblPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPSupplier.Location = new System.Drawing.Point(184, 241);
            lblPSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPSupplier.Name = "lblPSupplier";
            lblPSupplier.Size = new System.Drawing.Size(117, 17);
            lblPSupplier.TabIndex = 12;
            lblPSupplier.Text = "Product Supplier:";
            lblPSupplier.Click += new System.EventHandler(this.p_SupplierLabel_Click);
            // 
            // lblPUOM
            // 
            lblPUOM.AutoSize = true;
            lblPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPUOM.Location = new System.Drawing.Point(184, 276);
            lblPUOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPUOM.Name = "lblPUOM";
            lblPUOM.Size = new System.Drawing.Size(97, 17);
            lblPUOM.TabIndex = 14;
            lblPUOM.Text = "Product UOM:";
            // 
            // lblPGroup
            // 
            lblPGroup.AutoSize = true;
            lblPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPGroup.Location = new System.Drawing.Point(184, 309);
            lblPGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPGroup.Name = "lblPGroup";
            lblPGroup.Size = new System.Drawing.Size(105, 17);
            lblPGroup.TabIndex = 16;
            lblPGroup.Text = "Product Group:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(184, 342);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 17);
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
            this.menuBar.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuBar.Size = new System.Drawing.Size(800, 24);
            this.menuBar.TabIndex = 2;
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
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
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
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
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.predictionToolStripMenuItem.Text = "Prediction";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_ID", true));
            this.p_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_IDTextBox.Location = new System.Drawing.Point(334, 59);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_IDTextBox.TabIndex = 4;
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
            this.p_NameTextBox.Location = new System.Drawing.Point(334, 96);
            this.p_NameTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_NameTextBox.Name = "p_NameTextBox";
            this.p_NameTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_NameTextBox.TabIndex = 5;
            // 
            // p_QuantityTextBox
            // 
            this.p_QuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Quantity", true));
            this.p_QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_QuantityTextBox.Location = new System.Drawing.Point(334, 131);
            this.p_QuantityTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_QuantityTextBox.Name = "p_QuantityTextBox";
            this.p_QuantityTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_QuantityTextBox.TabIndex = 7;
            // 
            // p_PriceTextBox
            // 
            this.p_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Price", true));
            this.p_PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PriceTextBox.Location = new System.Drawing.Point(334, 168);
            this.p_PriceTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_PriceTextBox.Name = "p_PriceTextBox";
            this.p_PriceTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_PriceTextBox.TabIndex = 9;
            this.p_PriceTextBox.TextChanged += new System.EventHandler(this.p_PriceTextBox_TextChanged);
            // 
            // p_CostTextBox
            // 
            this.p_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Cost", true));
            this.p_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_CostTextBox.Location = new System.Drawing.Point(334, 204);
            this.p_CostTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_CostTextBox.Name = "p_CostTextBox";
            this.p_CostTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_CostTextBox.TabIndex = 11;
            // 
            // p_SupplierTextBox
            // 
            this.p_SupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Supplier", true));
            this.p_SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SupplierTextBox.Location = new System.Drawing.Point(334, 239);
            this.p_SupplierTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_SupplierTextBox.Name = "p_SupplierTextBox";
            this.p_SupplierTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_SupplierTextBox.TabIndex = 13;
            // 
            // p_UOMComboBox
            // 
            this.p_UOMComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_UOMComboBox.FormattingEnabled = true;
            this.p_UOMComboBox.Items.AddRange(new object[] {
            "Bottle",
            "Pcs",
            "Tablet",
            "Gram"});
            this.p_UOMComboBox.Location = new System.Drawing.Point(334, 273);
            this.p_UOMComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_UOMComboBox.Name = "p_UOMComboBox";
            this.p_UOMComboBox.Size = new System.Drawing.Size(279, 25);
            this.p_UOMComboBox.TabIndex = 17;
            // 
            // p_GroupComboBox
            // 
            this.p_GroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_GroupComboBox.FormattingEnabled = true;
            this.p_GroupComboBox.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.p_GroupComboBox.Location = new System.Drawing.Point(334, 306);
            this.p_GroupComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_GroupComboBox.Name = "p_GroupComboBox";
            this.p_GroupComboBox.Size = new System.Drawing.Size(279, 25);
            this.p_GroupComboBox.Sorted = true;
            this.p_GroupComboBox.TabIndex = 18;
            this.p_GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.p_GroupComboBox_SelectedIndexChanged);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(410, 384);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(112, 33);
            this.btnCancelProduct.TabIndex = 21;
            this.btnCancelProduct.Text = "&Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = false;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(294, 384);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 33);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "&Add New";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // p_SubGroupComboBox
            // 
            this.p_SubGroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SubGroupComboBox.FormattingEnabled = true;
            this.p_SubGroupComboBox.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.p_SubGroupComboBox.Location = new System.Drawing.Point(334, 339);
            this.p_SubGroupComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.p_SubGroupComboBox.Name = "p_SubGroupComboBox";
            this.p_SubGroupComboBox.Size = new System.Drawing.Size(279, 25);
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
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.p_QuantityTextBox);
            this.Controls.Add(lblPName);
            this.Controls.Add(this.p_NameTextBox);
            this.Controls.Add(lblPID);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.menuBar);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox p_QuantityTextBox;
        private System.Windows.Forms.TextBox p_PriceTextBox;
        private System.Windows.Forms.TextBox p_CostTextBox;
        private System.Windows.Forms.TextBox p_SupplierTextBox;
        private System.Windows.Forms.ComboBox p_GroupComboBox;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox p_UOMComboBox;
        private System.Windows.Forms.ComboBox p_SubGroupComboBox;
    }
}