namespace SRePS
{
    partial class frmSalesReport
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
            this.picDailyIcon = new System.Windows.Forms.PictureBox();
            this.picWeeklyIcon = new System.Windows.Forms.PictureBox();
            this.picMonthlyIcon = new System.Windows.Forms.PictureBox();
            this.lblDSalesReport = new System.Windows.Forms.Label();
            this.lblWSalesReport = new System.Windows.Forms.Label();
            this.lblMSalesReport = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picDailyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeeklyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthlyIcon)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDailyIcon
            // 
            this.picDailyIcon.Image = global::SRePS.Properties.Resources.dailyIcon;
            this.picDailyIcon.Location = new System.Drawing.Point(104, 189);
            this.picDailyIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picDailyIcon.Name = "picDailyIcon";
            this.picDailyIcon.Size = new System.Drawing.Size(162, 162);
            this.picDailyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDailyIcon.TabIndex = 0;
            this.picDailyIcon.TabStop = false;
            this.picDailyIcon.Click += new System.EventHandler(this.picDailyIcon_Click);
            // 
            // picWeeklyIcon
            // 
            this.picWeeklyIcon.Image = global::SRePS.Properties.Resources.weeklyIcon;
            this.picWeeklyIcon.Location = new System.Drawing.Point(471, 189);
            this.picWeeklyIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picWeeklyIcon.Name = "picWeeklyIcon";
            this.picWeeklyIcon.Size = new System.Drawing.Size(162, 162);
            this.picWeeklyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picWeeklyIcon.TabIndex = 0;
            this.picWeeklyIcon.TabStop = false;
            this.picWeeklyIcon.Click += new System.EventHandler(this.picWeeklyIcon_Click);
            // 
            // picMonthlyIcon
            // 
            this.picMonthlyIcon.Image = global::SRePS.Properties.Resources.monthlyIcon;
            this.picMonthlyIcon.Location = new System.Drawing.Point(848, 189);
            this.picMonthlyIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMonthlyIcon.Name = "picMonthlyIcon";
            this.picMonthlyIcon.Size = new System.Drawing.Size(163, 162);
            this.picMonthlyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMonthlyIcon.TabIndex = 0;
            this.picMonthlyIcon.TabStop = false;
            this.picMonthlyIcon.Click += new System.EventHandler(this.picMonthlyIcon_Click);
            // 
            // lblDSalesReport
            // 
            this.lblDSalesReport.AutoSize = true;
            this.lblDSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSalesReport.Location = new System.Drawing.Point(164, 469);
            this.lblDSalesReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSalesReport.Name = "lblDSalesReport";
            this.lblDSalesReport.Size = new System.Drawing.Size(117, 25);
            this.lblDSalesReport.TabIndex = 1;
            this.lblDSalesReport.Text = "Daily Report";
            // 
            // lblWSalesReport
            // 
            this.lblWSalesReport.AutoSize = true;
            this.lblWSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWSalesReport.Location = new System.Drawing.Point(520, 469);
            this.lblWSalesReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWSalesReport.Name = "lblWSalesReport";
            this.lblWSalesReport.Size = new System.Drawing.Size(140, 25);
            this.lblWSalesReport.TabIndex = 1;
            this.lblWSalesReport.Text = "Weekly Report";
            // 
            // lblMSalesReport
            // 
            this.lblMSalesReport.AutoSize = true;
            this.lblMSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSalesReport.Location = new System.Drawing.Point(898, 469);
            this.lblMSalesReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSalesReport.Name = "lblMSalesReport";
            this.lblMSalesReport.Size = new System.Drawing.Size(143, 25);
            this.lblMSalesReport.TabIndex = 1;
            this.lblMSalesReport.Text = "Monthly Report";
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
            this.menuBar.TabIndex = 2;
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
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
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
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.lblMSalesReport);
            this.Controls.Add(this.lblWSalesReport);
            this.Controls.Add(this.lblDSalesReport);
            this.Controls.Add(this.picMonthlyIcon);
            this.Controls.Add(this.picWeeklyIcon);
            this.Controls.Add(this.picDailyIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSalesReport";
            this.Text = "Family Aid Pharmacy Inc. SRePS - Sales Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesReport_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picDailyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeeklyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonthlyIcon)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDailyIcon;
        private System.Windows.Forms.PictureBox picWeeklyIcon;
        private System.Windows.Forms.PictureBox picMonthlyIcon;
        private System.Windows.Forms.Label lblDSalesReport;
        private System.Windows.Forms.Label lblWSalesReport;
        private System.Windows.Forms.Label lblMSalesReport;
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
    }
}