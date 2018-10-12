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
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.p_NameTextBox = new System.Windows.Forms.TextBox();
            this.p_QuantityTextBox = new System.Windows.Forms.TextBox();
            this.p_PriceTextBox = new System.Windows.Forms.TextBox();
            this.p_CostTextBox = new System.Windows.Forms.TextBox();
            this.p_SupplierTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            lblPID = new System.Windows.Forms.Label();
            lblPName = new System.Windows.Forms.Label();
            lblPQuantity = new System.Windows.Forms.Label();
            lblPPrice = new System.Windows.Forms.Label();
            lblPCost = new System.Windows.Forms.Label();
            lblPSupplier = new System.Windows.Forms.Label();
            lblPUOM = new System.Windows.Forms.Label();
            lblPGroup = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPID
            // 
            lblPID.AutoSize = true;
            lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPID.Location = new System.Drawing.Point(92, 63);
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
            lblPName.Location = new System.Drawing.Point(92, 93);
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
            lblPQuantity.Location = new System.Drawing.Point(92, 123);
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
            lblPPrice.Location = new System.Drawing.Point(92, 154);
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
            lblPCost.Location = new System.Drawing.Point(92, 184);
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
            lblPSupplier.Location = new System.Drawing.Point(92, 214);
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
            lblPUOM.Location = new System.Drawing.Point(92, 244);
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
            lblPGroup.Location = new System.Drawing.Point(92, 276);
            lblPGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPGroup.Name = "lblPGroup";
            lblPGroup.Size = new System.Drawing.Size(105, 17);
            lblPGroup.TabIndex = 16;
            lblPGroup.Text = "Product Group:";
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
            this.menuBar.Size = new System.Drawing.Size(606, 24);
            this.menuBar.TabIndex = 2;
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
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
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
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.predictionToolStripMenuItem.Text = "Prediction";
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
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_ID", true));
            this.p_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_IDTextBox.Location = new System.Drawing.Point(214, 60);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_IDTextBox.TabIndex = 4;
            // 
            // p_NameTextBox
            // 
            this.p_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Name", true));
            this.p_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_NameTextBox.Location = new System.Drawing.Point(214, 90);
            this.p_NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_NameTextBox.Name = "p_NameTextBox";
            this.p_NameTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_NameTextBox.TabIndex = 5;
            // 
            // p_QuantityTextBox
            // 
            this.p_QuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Quantity", true));
            this.p_QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_QuantityTextBox.Location = new System.Drawing.Point(214, 120);
            this.p_QuantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_QuantityTextBox.Name = "p_QuantityTextBox";
            this.p_QuantityTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_QuantityTextBox.TabIndex = 7;
            // 
            // p_PriceTextBox
            // 
            this.p_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Price", true));
            this.p_PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PriceTextBox.Location = new System.Drawing.Point(214, 151);
            this.p_PriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_PriceTextBox.Name = "p_PriceTextBox";
            this.p_PriceTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_PriceTextBox.TabIndex = 9;
            this.p_PriceTextBox.TextChanged += new System.EventHandler(this.p_PriceTextBox_TextChanged);
            // 
            // p_CostTextBox
            // 
            this.p_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Cost", true));
            this.p_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_CostTextBox.Location = new System.Drawing.Point(214, 181);
            this.p_CostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_CostTextBox.Name = "p_CostTextBox";
            this.p_CostTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_CostTextBox.TabIndex = 11;
            // 
            // p_SupplierTextBox
            // 
            this.p_SupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_Supplier", true));
            this.p_SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SupplierTextBox.Location = new System.Drawing.Point(214, 211);
            this.p_SupplierTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.p_SupplierTextBox.Name = "p_SupplierTextBox";
            this.p_SupplierTextBox.Size = new System.Drawing.Size(279, 23);
            this.p_SupplierTextBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bottle",
            "Pcs",
            "Tablet",
            "Gram"});
            this.comboBox1.Location = new System.Drawing.Point(214, 241);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 25);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Medicine",
            "Healthcare",
            "Equipment"});
            this.comboBox2.Location = new System.Drawing.Point(214, 274);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(279, 25);
            this.comboBox2.TabIndex = 18;
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProduct.Location = new System.Drawing.Point(314, 306);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(84, 27);
            this.btnCancelProduct.TabIndex = 21;
            this.btnCancelProduct.Text = "&Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(225, 306);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(84, 27);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "&Add New";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 366);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddProduct";
            this.Text = "Family Aid Pharmacy Inc. SRePS - Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnAddProduct;
    }
}