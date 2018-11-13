namespace SRePS
{
    partial class frmEditProduct
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
            System.Windows.Forms.Label label1;
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPQuantity = new System.Windows.Forms.Label();
            this.lblPPrice = new System.Windows.Forms.Label();
            this.lblPCost = new System.Windows.Forms.Label();
            this.lblPSupplier = new System.Windows.Forms.Label();
            this.lblPUOM = new System.Windows.Forms.Label();
            this.lblPGroup = new System.Windows.Forms.Label();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.p_NameTextBox = new System.Windows.Forms.TextBox();
            this.p_PriceTextBox = new System.Windows.Forms.TextBox();
            this.p_CostTextBox = new System.Windows.Forms.TextBox();
            this.p_SupplierTextBox = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbPUOM = new System.Windows.Forms.ComboBox();
            this.cmbPGroup = new System.Windows.Forms.ComboBox();
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.cmbPSubGroup = new System.Windows.Forms.ComboBox();
            this.p_QuantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.lblArchive = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_QuantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(276, 520);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 25);
            label1.TabIndex = 27;
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
            this.employeesToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.predictionToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1200, 33);
            this.menuBar.TabIndex = 0;
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
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.employeesToolStripMenuItem.Text = "Employee";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
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
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportToolStripMenuItem_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.predictionToolStripMenuItem.Text = "Prediction";
            this.predictionToolStripMenuItem.Click += new System.EventHandler(this.predictionToolStripMenuItem_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(276, 66);
            this.lblPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(109, 25);
            this.lblPID.TabIndex = 1;
            this.lblPID.Text = "Product ID:";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(276, 122);
            this.lblPName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(142, 25);
            this.lblPName.TabIndex = 2;
            this.lblPName.Text = "Product Name:";
            // 
            // lblPQuantity
            // 
            this.lblPQuantity.AutoSize = true;
            this.lblPQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPQuantity.Location = new System.Drawing.Point(278, 408);
            this.lblPQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPQuantity.Name = "lblPQuantity";
            this.lblPQuantity.Size = new System.Drawing.Size(163, 25);
            this.lblPQuantity.TabIndex = 3;
            this.lblPQuantity.Text = "Product Quantity:";
            this.lblPQuantity.Click += new System.EventHandler(this.lblPQuantity_Click);
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPrice.Location = new System.Drawing.Point(278, 182);
            this.lblPPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(134, 25);
            this.lblPPrice.TabIndex = 4;
            this.lblPPrice.Text = "Product Price:";
            // 
            // lblPCost
            // 
            this.lblPCost.AutoSize = true;
            this.lblPCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCost.Location = new System.Drawing.Point(278, 238);
            this.lblPCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCost.Name = "lblPCost";
            this.lblPCost.Size = new System.Drawing.Size(136, 25);
            this.lblPCost.TabIndex = 5;
            this.lblPCost.Text = "Product Cost :";
            this.lblPCost.Click += new System.EventHandler(this.lblPCost_Click);
            // 
            // lblPSupplier
            // 
            this.lblPSupplier.AutoSize = true;
            this.lblPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSupplier.Location = new System.Drawing.Point(278, 295);
            this.lblPSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSupplier.Name = "lblPSupplier";
            this.lblPSupplier.Size = new System.Drawing.Size(162, 25);
            this.lblPSupplier.TabIndex = 6;
            this.lblPSupplier.Text = "Product Supplier:";
            // 
            // lblPUOM
            // 
            this.lblPUOM.AutoSize = true;
            this.lblPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUOM.Location = new System.Drawing.Point(278, 352);
            this.lblPUOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUOM.Name = "lblPUOM";
            this.lblPUOM.Size = new System.Drawing.Size(137, 25);
            this.lblPUOM.TabIndex = 7;
            this.lblPUOM.Text = "Product UOM:";
            // 
            // lblPGroup
            // 
            this.lblPGroup.AutoSize = true;
            this.lblPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGroup.Location = new System.Drawing.Point(278, 466);
            this.lblPGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPGroup.Name = "lblPGroup";
            this.lblPGroup.Size = new System.Drawing.Size(144, 25);
            this.lblPGroup.TabIndex = 8;
            this.lblPGroup.Text = "Product Group:";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_IDTextBox.Location = new System.Drawing.Point(501, 62);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(416, 30);
            this.p_IDTextBox.TabIndex = 9;
            // 
            // p_NameTextBox
            // 
            this.p_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_NameTextBox.Location = new System.Drawing.Point(501, 118);
            this.p_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_NameTextBox.Name = "p_NameTextBox";
            this.p_NameTextBox.Size = new System.Drawing.Size(416, 30);
            this.p_NameTextBox.TabIndex = 10;
            // 
            // p_PriceTextBox
            // 
            this.p_PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PriceTextBox.Location = new System.Drawing.Point(501, 177);
            this.p_PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_PriceTextBox.Name = "p_PriceTextBox";
            this.p_PriceTextBox.Size = new System.Drawing.Size(416, 30);
            this.p_PriceTextBox.TabIndex = 12;
            // 
            // p_CostTextBox
            // 
            this.p_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_CostTextBox.Location = new System.Drawing.Point(501, 232);
            this.p_CostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_CostTextBox.Name = "p_CostTextBox";
            this.p_CostTextBox.Size = new System.Drawing.Size(416, 30);
            this.p_CostTextBox.TabIndex = 13;
            // 
            // p_SupplierTextBox
            // 
            this.p_SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SupplierTextBox.Location = new System.Drawing.Point(501, 292);
            this.p_SupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_SupplierTextBox.Name = "p_SupplierTextBox";
            this.p_SupplierTextBox.Size = new System.Drawing.Size(416, 30);
            this.p_SupplierTextBox.TabIndex = 14;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(441, 625);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(168, 51);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(618, 625);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 51);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbPUOM
            // 
            this.cmbPUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPUOM.FormattingEnabled = true;
            this.cmbPUOM.Items.AddRange(new object[] {
            "Bottle",
            "Dozen",
            "Gram",
            "Pcs",
            "Tablet"});
            this.cmbPUOM.Location = new System.Drawing.Point(501, 346);
            this.cmbPUOM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPUOM.Name = "cmbPUOM";
            this.cmbPUOM.Size = new System.Drawing.Size(416, 33);
            this.cmbPUOM.TabIndex = 15;
            // 
            // cmbPGroup
            // 
            this.cmbPGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPGroup.FormattingEnabled = true;
            this.cmbPGroup.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.cmbPGroup.Location = new System.Drawing.Point(501, 460);
            this.cmbPGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPGroup.Name = "cmbPGroup";
            this.cmbPGroup.Size = new System.Drawing.Size(416, 33);
            this.cmbPGroup.TabIndex = 16;
            this.cmbPGroup.SelectedIndexChanged += new System.EventHandler(this.cmbPGroup_SelectedIndexChanged);
            // 
            // sRePS_DatabaseDataSet
            // 
            this.sRePS_DatabaseDataSet.DataSetName = "SRePS_DatabaseDataSet";
            this.sRePS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbPSubGroup
            // 
            this.cmbPSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPSubGroup.FormattingEnabled = true;
            this.cmbPSubGroup.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.cmbPSubGroup.Location = new System.Drawing.Point(501, 515);
            this.cmbPSubGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPSubGroup.Name = "cmbPSubGroup";
            this.cmbPSubGroup.Size = new System.Drawing.Size(416, 33);
            this.cmbPSubGroup.Sorted = true;
            this.cmbPSubGroup.TabIndex = 28;
            // 
            // p_QuantityUpDown
            // 
            this.p_QuantityUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_QuantityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_QuantityUpDown.Location = new System.Drawing.Point(501, 403);
            this.p_QuantityUpDown.Name = "p_QuantityUpDown";
            this.p_QuantityUpDown.Size = new System.Drawing.Size(417, 31);
            this.p_QuantityUpDown.TabIndex = 29;
            this.p_QuantityUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFalse.Location = new System.Drawing.Point(618, 574);
            this.rdFalse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(85, 29);
            this.rdFalse.TabIndex = 35;
            this.rdFalse.TabStop = true;
            this.rdFalse.Text = "False";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTrue.Location = new System.Drawing.Point(498, 574);
            this.rdTrue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(78, 29);
            this.rdTrue.TabIndex = 34;
            this.rdTrue.TabStop = true;
            this.rdTrue.Text = "True";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchive.Location = new System.Drawing.Point(278, 577);
            this.lblArchive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(84, 25);
            this.lblArchive.TabIndex = 33;
            this.lblArchive.Text = "Archive:";
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.rdFalse);
            this.Controls.Add(this.rdTrue);
            this.Controls.Add(this.lblArchive);
            this.Controls.Add(this.p_QuantityUpDown);
            this.Controls.Add(this.cmbPSubGroup);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbPGroup);
            this.Controls.Add(this.cmbPUOM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.p_SupplierTextBox);
            this.Controls.Add(this.p_CostTextBox);
            this.Controls.Add(this.p_PriceTextBox);
            this.Controls.Add(this.p_NameTextBox);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.lblPGroup);
            this.Controls.Add(this.lblPUOM);
            this.Controls.Add(this.lblPSupplier);
            this.Controls.Add(this.lblPCost);
            this.Controls.Add(this.lblPPrice);
            this.Controls.Add(this.lblPQuantity);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Edit Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_QuantityUpDown)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPQuantity;
        private System.Windows.Forms.Label lblPPrice;
        private System.Windows.Forms.Label lblPCost;
        private System.Windows.Forms.Label lblPSupplier;
        private System.Windows.Forms.Label lblPUOM;
        private System.Windows.Forms.Label lblPGroup;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SRePS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox p_IDTextBox;
        public System.Windows.Forms.TextBox p_NameTextBox;
        public System.Windows.Forms.TextBox p_PriceTextBox;
        public System.Windows.Forms.TextBox p_CostTextBox;
        public System.Windows.Forms.TextBox p_SupplierTextBox;
        public System.Windows.Forms.ComboBox cmbPUOM;
        public System.Windows.Forms.ComboBox cmbPGroup;
        public System.Windows.Forms.ComboBox cmbPSubGroup;
        public System.Windows.Forms.NumericUpDown p_QuantityUpDown;
        public System.Windows.Forms.RadioButton rdFalse;
        public System.Windows.Forms.RadioButton rdTrue;
        public System.Windows.Forms.Label lblArchive;
    }
}