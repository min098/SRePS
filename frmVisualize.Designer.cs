namespace SRePS
{
    partial class frmVisualize
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
            this.lblVRevenue = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.barchart = new System.Windows.Forms.PictureBox();
            this.linegraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linegraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVRevenue
            // 
            this.lblVRevenue.AutoSize = true;
            this.lblVRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVRevenue.Location = new System.Drawing.Point(184, 275);
            this.lblVRevenue.Name = "lblVRevenue";
            this.lblVRevenue.Size = new System.Drawing.Size(151, 16);
            this.lblVRevenue.TabIndex = 2;
            this.lblVRevenue.Text = "Visulization for Revenue";
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTS.Location = new System.Drawing.Point(456, 274);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(159, 16);
            this.lblTS.TabIndex = 3;
            this.lblTS.Text = "Visulization for Top Sales";
            // 
            // barchart
            // 
            this.barchart.Image = global::SRePS.Properties.Resources.barchart;
            this.barchart.Location = new System.Drawing.Point(442, 108);
            this.barchart.Margin = new System.Windows.Forms.Padding(2);
            this.barchart.Name = "barchart";
            this.barchart.Size = new System.Drawing.Size(189, 163);
            this.barchart.TabIndex = 7;
            this.barchart.TabStop = false;
            this.barchart.Click += new System.EventHandler(this.barchart_Click_1);
            // 
            // linegraph
            // 
            this.linegraph.Image = global::SRePS.Properties.Resources.linegraph;
            this.linegraph.Location = new System.Drawing.Point(164, 111);
            this.linegraph.Margin = new System.Windows.Forms.Padding(2);
            this.linegraph.Name = "linegraph";
            this.linegraph.Size = new System.Drawing.Size(189, 163);
            this.linegraph.TabIndex = 6;
            this.linegraph.TabStop = false;
            this.linegraph.Click += new System.EventHandler(this.linegraph_Click_1);
            // 
            // frmVisualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barchart);
            this.Controls.Add(this.linegraph);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.lblVRevenue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVisualize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Family Aid Pharmacy Inc. SRePS - Visualization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVisualize_FormClosing);
            this.Load += new System.EventHandler(this.frmVisualize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linegraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVRevenue;
        private System.Windows.Forms.Label lblTS;
        private System.Windows.Forms.PictureBox barchart;
        private System.Windows.Forms.PictureBox linegraph;
    }
}