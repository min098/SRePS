namespace SRePS
{
    partial class frmPayment
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
            System.Windows.Forms.Label lblTotal;
            System.Windows.Forms.Label lblPaid;
            System.Windows.Forms.Label lblChange;
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            lblPaid = new System.Windows.Forms.Label();
            lblChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotal.Location = new System.Drawing.Point(117, 98);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(51, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPaid.Location = new System.Drawing.Point(117, 146);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new System.Drawing.Size(47, 20);
            lblPaid.TabIndex = 9;
            lblPaid.Text = "Paid:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblChange.Location = new System.Drawing.Point(117, 189);
            lblChange.Name = "lblChange";
            lblChange.Size = new System.Drawing.Size(71, 20);
            lblChange.TabIndex = 10;
            lblChange.Text = "Change:";
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(194, 143);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(371, 27);
            this.txtPaid.TabIndex = 8;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(194, 186);
            this.txtChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(371, 27);
            this.txtChange.TabIndex = 11;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(194, 241);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(149, 41);
            this.btnCommit.TabIndex = 21;
            this.btnCommit.Text = "&Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(349, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(194, 98);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(371, 27);
            this.txtTotal.TabIndex = 24;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 358);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(lblChange);
            this.Controls.Add(lblPaid);
            this.Controls.Add(lblTotal);
            this.Controls.Add(this.txtPaid);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSalesFamily Aid Pharmacy Inc. SRePS - Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTotal;
    }
}