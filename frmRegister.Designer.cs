namespace SRePS
{
    partial class frmRegister
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPosistion = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.e_UserNameTextBox = new System.Windows.Forms.TextBox();
            this.e_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.e_ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.menuBar.TabIndex = 0;
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logToolStripMenuItem.Text = "Log Out";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
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
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(217, 132);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 16);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(217, 160);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(217, 189);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(119, 16);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPosistion
            // 
            this.lblPosistion.AutoSize = true;
            this.lblPosistion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosistion.Location = new System.Drawing.Point(217, 219);
            this.lblPosistion.Name = "lblPosistion";
            this.lblPosistion.Size = new System.Drawing.Size(59, 16);
            this.lblPosistion.TabIndex = 4;
            this.lblPosistion.Text = "Position:";
            this.lblPosistion.Click += new System.EventHandler(this.lblPosistion_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(217, 248);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // e_UserNameTextBox
            // 
            this.e_UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_UserNameTextBox.Location = new System.Drawing.Point(342, 129);
            this.e_UserNameTextBox.Name = "e_UserNameTextBox";
            this.e_UserNameTextBox.Size = new System.Drawing.Size(211, 22);
            this.e_UserNameTextBox.TabIndex = 6;
            // 
            // e_PasswordTextBox
            // 
            this.e_PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_PasswordTextBox.Location = new System.Drawing.Point(342, 158);
            this.e_PasswordTextBox.Name = "e_PasswordTextBox";
            this.e_PasswordTextBox.Size = new System.Drawing.Size(211, 22);
            this.e_PasswordTextBox.TabIndex = 7;
            // 
            // e_ConfirmPasswordTextBox
            // 
            this.e_ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_ConfirmPasswordTextBox.Location = new System.Drawing.Point(342, 188);
            this.e_ConfirmPasswordTextBox.Name = "e_ConfirmPasswordTextBox";
            this.e_ConfirmPasswordTextBox.Size = new System.Drawing.Size(211, 22);
            this.e_ConfirmPasswordTextBox.TabIndex = 8;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(342, 219);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(211, 21);
            this.cmbPosition.TabIndex = 9;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.Location = new System.Drawing.Point(342, 248);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(56, 20);
            this.rdMale.TabIndex = 10;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.Location = new System.Drawing.Point(422, 248);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(72, 20);
            this.rdFemale.TabIndex = 11;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(325, 298);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 27);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(415, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.e_ConfirmPasswordTextBox);
            this.Controls.Add(this.e_PasswordTextBox);
            this.Controls.Add(this.e_UserNameTextBox);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPosistion);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmRegister";
            this.Text = "Family Aid Pharmacy Inc. SRePS - Register/Add Employee";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPosistion;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox e_UserNameTextBox;
        private System.Windows.Forms.TextBox e_PasswordTextBox;
        private System.Windows.Forms.TextBox e_ConfirmPasswordTextBox;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}