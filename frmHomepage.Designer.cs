﻿namespace SRePS
{
    partial class frmHomepage
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.lblPrediction = new System.Windows.Forms.Label();
            this.picPrediction = new System.Windows.Forms.PictureBox();
            this.picSalesReport = new System.Windows.Forms.PictureBox();
            this.picEmployees = new System.Windows.Forms.PictureBox();
            this.picSales = new System.Windows.Forms.PictureBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.sRePS_DatabaseDataSet = new SRePS.SRePS_DatabaseDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SRePS.SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new SRePS.SRePS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrediction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRePS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.menuBar.Size = new System.Drawing.Size(830, 24);
            this.menuBar.TabIndex = 0;
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
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
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
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(163, 189);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(61, 16);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(388, 189);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(43, 16);
            this.lblSales.TabIndex = 2;
            this.lblSales.Text = "Sales";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(595, 189);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(77, 16);
            this.lblEmployees.TabIndex = 3;
            this.lblEmployees.Text = "Employees";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(257, 394);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(87, 16);
            this.lblSalesReport.TabIndex = 4;
            this.lblSalesReport.Text = "Sales Report";
            this.lblSalesReport.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrediction
            // 
            this.lblPrediction.AutoSize = true;
            this.lblPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrediction.Location = new System.Drawing.Point(499, 394);
            this.lblPrediction.Name = "lblPrediction";
            this.lblPrediction.Size = new System.Drawing.Size(68, 16);
            this.lblPrediction.TabIndex = 5;
            this.lblPrediction.Text = "Prediction";
            // 
            // picPrediction
            // 
            this.picPrediction.Image = global::SRePS.Properties.Resources.Prediction;
            this.picPrediction.Location = new System.Drawing.Point(472, 248);
            this.picPrediction.Name = "picPrediction";
            this.picPrediction.Size = new System.Drawing.Size(125, 122);
            this.picPrediction.TabIndex = 10;
            this.picPrediction.TabStop = false;
            this.picPrediction.Click += new System.EventHandler(this.picPrediction_Click);
            // 
            // picSalesReport
            // 
            this.picSalesReport.Image = global::SRePS.Properties.Resources.Sales_Report;
            this.picSalesReport.Location = new System.Drawing.Point(238, 248);
            this.picSalesReport.Name = "picSalesReport";
            this.picSalesReport.Size = new System.Drawing.Size(127, 122);
            this.picSalesReport.TabIndex = 9;
            this.picSalesReport.TabStop = false;
            this.picSalesReport.Click += new System.EventHandler(this.picSalesReport_Click);
            // 
            // picEmployees
            // 
            this.picEmployees.Image = global::SRePS.Properties.Resources.Employees;
            this.picEmployees.Location = new System.Drawing.Point(569, 51);
            this.picEmployees.Name = "picEmployees";
            this.picEmployees.Size = new System.Drawing.Size(122, 122);
            this.picEmployees.TabIndex = 8;
            this.picEmployees.TabStop = false;
            this.picEmployees.Click += new System.EventHandler(this.picEmployees_Click);
            // 
            // picSales
            // 
            this.picSales.Image = global::SRePS.Properties.Resources.Sales;
            this.picSales.Location = new System.Drawing.Point(350, 51);
            this.picSales.Name = "picSales";
            this.picSales.Size = new System.Drawing.Size(127, 122);
            this.picSales.TabIndex = 7;
            this.picSales.TabStop = false;
            this.picSales.Click += new System.EventHandler(this.picSales_Click);
            // 
            // picProduct
            // 
            this.picProduct.Image = global::SRePS.Properties.Resources.Products;
            this.picProduct.Location = new System.Drawing.Point(137, 51);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(122, 122);
            this.picProduct.TabIndex = 6;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
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
            // frmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 452);
            this.Controls.Add(this.picPrediction);
            this.Controls.Add(this.picSalesReport);
            this.Controls.Add(this.picEmployees);
            this.Controls.Add(this.picSales);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.lblPrediction);
            this.Controls.Add(this.lblSalesReport);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomepage_FormClosing);
            this.Load += new System.EventHandler(this.frmHomepage_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrediction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
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
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblPrediction;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.PictureBox picSales;
        private System.Windows.Forms.PictureBox picEmployees;
        private System.Windows.Forms.PictureBox picSalesReport;
        private System.Windows.Forms.PictureBox picPrediction;
        private SRePS_DatabaseDataSet sRePS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SRePS_DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SRePS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}