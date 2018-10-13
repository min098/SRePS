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
            this.p_QuantityTextBox = new System.Windows.Forms.TextBox();
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
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.employeesToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.predictionToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1067, 28);
            this.menuBar.TabIndex = 0;
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeesToolStripMenuItem.Text = "Employee";
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
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.predictionToolStripMenuItem.Text = "Prediction";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(244, 94);
            this.lblPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(94, 20);
            this.lblPID.TabIndex = 1;
            this.lblPID.Text = "Product ID:";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.Location = new System.Drawing.Point(244, 135);
            this.lblPName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(121, 20);
            this.lblPName.TabIndex = 2;
            this.lblPName.Text = "Product Name:";
            // 
            // lblPQuantity
            // 
            this.lblPQuantity.AutoSize = true;
            this.lblPQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPQuantity.Location = new System.Drawing.Point(244, 176);
            this.lblPQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPQuantity.Name = "lblPQuantity";
            this.lblPQuantity.Size = new System.Drawing.Size(139, 20);
            this.lblPQuantity.TabIndex = 3;
            this.lblPQuantity.Text = "Product Quantity:";
            this.lblPQuantity.Click += new System.EventHandler(this.lblPQuantity_Click);
            // 
            // lblPPrice
            // 
            this.lblPPrice.AutoSize = true;
            this.lblPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPrice.Location = new System.Drawing.Point(244, 218);
            this.lblPPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPrice.Name = "lblPPrice";
            this.lblPPrice.Size = new System.Drawing.Size(116, 20);
            this.lblPPrice.TabIndex = 4;
            this.lblPPrice.Text = "Product Price:";
            // 
            // lblPCost
            // 
            this.lblPCost.AutoSize = true;
            this.lblPCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCost.Location = new System.Drawing.Point(244, 261);
            this.lblPCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPCost.Name = "lblPCost";
            this.lblPCost.Size = new System.Drawing.Size(117, 20);
            this.lblPCost.TabIndex = 5;
            this.lblPCost.Text = "Product Cost :";
            this.lblPCost.Click += new System.EventHandler(this.lblPCost_Click);
            // 
            // lblPSupplier
            // 
            this.lblPSupplier.AutoSize = true;
            this.lblPSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSupplier.Location = new System.Drawing.Point(244, 300);
            this.lblPSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPSupplier.Name = "lblPSupplier";
            this.lblPSupplier.Size = new System.Drawing.Size(138, 20);
            this.lblPSupplier.TabIndex = 6;
            this.lblPSupplier.Text = "Product Supplier:";
            // 
            // lblPUOM
            // 
            this.lblPUOM.AutoSize = true;
            this.lblPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUOM.Location = new System.Drawing.Point(244, 345);
            this.lblPUOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPUOM.Name = "lblPUOM";
            this.lblPUOM.Size = new System.Drawing.Size(116, 20);
            this.lblPUOM.TabIndex = 7;
            this.lblPUOM.Text = "Product UOM:";
            // 
            // lblPGroup
            // 
            this.lblPGroup.AutoSize = true;
            this.lblPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGroup.Location = new System.Drawing.Point(244, 389);
            this.lblPGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPGroup.Name = "lblPGroup";
            this.lblPGroup.Size = new System.Drawing.Size(123, 20);
            this.lblPGroup.TabIndex = 8;
            this.lblPGroup.Text = "Product Group:";
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_IDTextBox.Location = new System.Drawing.Point(401, 91);
            this.p_IDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_IDTextBox.TabIndex = 9;
            // 
            // p_NameTextBox
            // 
            this.p_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_NameTextBox.Location = new System.Drawing.Point(401, 133);
            this.p_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_NameTextBox.Name = "p_NameTextBox";
            this.p_NameTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_NameTextBox.TabIndex = 10;
            // 
            // p_QuantityTextBox
            // 
            this.p_QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_QuantityTextBox.Location = new System.Drawing.Point(401, 175);
            this.p_QuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_QuantityTextBox.Name = "p_QuantityTextBox";
            this.p_QuantityTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_QuantityTextBox.TabIndex = 11;
            // 
            // p_PriceTextBox
            // 
            this.p_PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_PriceTextBox.Location = new System.Drawing.Point(401, 215);
            this.p_PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_PriceTextBox.Name = "p_PriceTextBox";
            this.p_PriceTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_PriceTextBox.TabIndex = 12;
            // 
            // p_CostTextBox
            // 
            this.p_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_CostTextBox.Location = new System.Drawing.Point(401, 257);
            this.p_CostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_CostTextBox.Name = "p_CostTextBox";
            this.p_CostTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_CostTextBox.TabIndex = 13;
            // 
            // p_SupplierTextBox
            // 
            this.p_SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_SupplierTextBox.Location = new System.Drawing.Point(401, 299);
            this.p_SupplierTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_SupplierTextBox.Name = "p_SupplierTextBox";
            this.p_SupplierTextBox.Size = new System.Drawing.Size(319, 26);
            this.p_SupplierTextBox.TabIndex = 14;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(295, 464);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(169, 33);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(499, 464);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 33);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cmbPUOM
            // 
            this.cmbPUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPUOM.FormattingEnabled = true;
            this.cmbPUOM.Location = new System.Drawing.Point(401, 341);
            this.cmbPUOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPUOM.Name = "cmbPUOM";
            this.cmbPUOM.Size = new System.Drawing.Size(319, 28);
            this.cmbPUOM.TabIndex = 15;
            // 
            // cmbPGroup
            // 
            this.cmbPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPGroup.FormattingEnabled = true;
            this.cmbPGroup.Location = new System.Drawing.Point(401, 385);
            this.cmbPGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPGroup.Name = "cmbPGroup";
            this.cmbPGroup.Size = new System.Drawing.Size(319, 28);
            this.cmbPGroup.TabIndex = 16;
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
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbPGroup);
            this.Controls.Add(this.cmbPUOM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.p_SupplierTextBox);
            this.Controls.Add(this.p_CostTextBox);
            this.Controls.Add(this.p_PriceTextBox);
            this.Controls.Add(this.p_QuantityTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditProduct";
            this.Text = "Family Aid Pharmacy Inc. SRePS - Edit Product";
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
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox p_NameTextBox;
        private System.Windows.Forms.TextBox p_QuantityTextBox;
        private System.Windows.Forms.TextBox p_PriceTextBox;
        private System.Windows.Forms.TextBox p_CostTextBox;
        private System.Windows.Forms.TextBox p_SupplierTextBox;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbPUOM;
        private System.Windows.Forms.ComboBox cmbPGroup;
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SRePS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}