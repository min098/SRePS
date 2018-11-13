namespace SRePS
{
    partial class frmEditEmployee
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
            System.Windows.Forms.Label lblPass;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblPosition;
            System.Windows.Forms.Label lblConfirmPass;
            System.Windows.Forms.Label lblUserName;
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.rdInactive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
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
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            lblPass = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblPosition = new System.Windows.Forms.Label();
            lblConfirmPass = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPass.Location = new System.Drawing.Point(278, 266);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(112, 25);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password:";
            lblPass.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new System.Drawing.Point(278, 220);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(74, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            lblName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPosition.Location = new System.Drawing.Point(278, 357);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new System.Drawing.Size(95, 25);
            lblPosition.TabIndex = 11;
            lblPosition.Text = "Position:";
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblConfirmPass.Location = new System.Drawing.Point(278, 311);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new System.Drawing.Size(192, 25);
            lblConfirmPass.TabIndex = 10;
            lblConfirmPass.Text = "Confirm Password:";
            lblConfirmPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUserName.Location = new System.Drawing.Point(277, 172);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(125, 25);
            lblUserName.TabIndex = 21;
            lblUserName.Text = "User Name:";
            lblUserName.Click += new System.EventHandler(this.lblUserName_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(478, 263);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(416, 31);
            this.txtPass.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(478, 217);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 31);
            this.txtName.TabIndex = 2;
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(478, 311);
            this.txtConPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '*';
            this.txtConPass.Size = new System.Drawing.Size(416, 31);
            this.txtConPass.TabIndex = 4;
            // 
            // rdInactive
            // 
            this.rdInactive.AutoSize = true;
            this.rdInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInactive.Location = new System.Drawing.Point(597, 405);
            this.rdInactive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdInactive.Name = "rdInactive";
            this.rdInactive.Size = new System.Drawing.Size(104, 29);
            this.rdInactive.TabIndex = 7;
            this.rdInactive.TabStop = true;
            this.rdInactive.Text = "Inactive";
            this.rdInactive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActive.Location = new System.Drawing.Point(477, 405);
            this.rdActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(91, 29);
            this.rdActive.TabIndex = 6;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Active";
            this.rdActive.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(278, 405);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(625, 459);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(438, 459);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(169, 42);
            this.btnEditEmployee.TabIndex = 8;
            this.btnEditEmployee.Text = "&Save Changes";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
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
            this.menuBar.Size = new System.Drawing.Size(1212, 33);
            this.menuBar.TabIndex = 19;
            this.menuBar.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
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
            this.predictionToolStripMenuItem.Click += new System.EventHandler(this.predictionToolStripMenuItem_Click);
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cmbPosition.Location = new System.Drawing.Point(477, 360);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(417, 28);
            this.cmbPosition.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(477, 169);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(416, 31);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 678);
            this.Controls.Add(lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.rdInactive);
            this.Controls.Add(this.rdActive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(lblPosition);
            this.Controls.Add(lblConfirmPass);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Name = "frmEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Edit Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditEmployee_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditEmployee;
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
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtConPass;
        public System.Windows.Forms.RadioButton rdInactive;
        public System.Windows.Forms.RadioButton rdActive;
        public System.Windows.Forms.ComboBox cmbPosition;
        public System.Windows.Forms.TextBox txtUserName;
    }
}