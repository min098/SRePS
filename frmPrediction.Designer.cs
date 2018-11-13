namespace SRePS
{
    partial class frmPrediction
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
            System.Windows.Forms.Label lblPGroup;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPredict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbSubGroup = new System.Windows.Forms.ComboBox();
            lblPGroup = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPredict)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPGroup
            // 
            lblPGroup.AutoSize = true;
            lblPGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPGroup.Location = new System.Drawing.Point(12, 28);
            lblPGroup.Name = "lblPGroup";
            lblPGroup.Size = new System.Drawing.Size(157, 25);
            lblPGroup.TabIndex = 22;
            lblPGroup.Text = "Product Group:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(485, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 25);
            label1.TabIndex = 25;
            label1.Text = "Product Sub-Group:";
            // 
            // chartPredict
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chartPredict.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPredict.Legends.Add(legend2);
            this.chartPredict.Location = new System.Drawing.Point(16, 77);
            this.chartPredict.Name = "chartPredict";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.CustomProperties = "LabelStyle=Center";
            series2.Legend = "Legend1";
            series2.Name = "This Month Sales";
            this.chartPredict.Series.Add(series2);
            this.chartPredict.Size = new System.Drawing.Size(1176, 609);
            this.chartPredict.TabIndex = 0;
            this.chartPredict.Text = "chart1";
            this.chartPredict.Click += new System.EventHandler(this.chartPredict_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualize.Location = new System.Drawing.Point(1029, 28);
            this.btnVisualize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(163, 35);
            this.btnVisualize.TabIndex = 23;
            this.btnVisualize.Text = "&Visualize";
            this.btnVisualize.UseVisualStyleBackColor = true;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.cmbGroup.Location = new System.Drawing.Point(175, 25);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(239, 33);
            this.cmbGroup.Sorted = true;
            this.cmbGroup.TabIndex = 21;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // cmbSubGroup
            // 
            this.cmbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubGroup.FormattingEnabled = true;
            this.cmbSubGroup.Items.AddRange(new object[] {
            "Equipment",
            "Healthcare",
            "Medicine"});
            this.cmbSubGroup.Location = new System.Drawing.Point(693, 28);
            this.cmbSubGroup.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmbSubGroup.Name = "cmbSubGroup";
            this.cmbSubGroup.Size = new System.Drawing.Size(239, 33);
            this.cmbSubGroup.Sorted = true;
            this.cmbSubGroup.TabIndex = 24;
            this.cmbSubGroup.SelectedIndexChanged += new System.EventHandler(this.cmbSubGroup_SelectedIndexChanged);
            // 
            // frmPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 702);
            this.Controls.Add(this.cmbSubGroup);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(lblPGroup);
            this.Controls.Add(this.chartPredict);
            this.Name = "frmPrediction";
            this.Text = "frmPrediction";
            this.Load += new System.EventHandler(this.frmPrediction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPredict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPredict;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbSubGroup;
    }
}