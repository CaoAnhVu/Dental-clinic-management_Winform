namespace PKNK_CNPM.Forms
{
    partial class frmThongKeVatLieu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartVaLieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVaLieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVaLieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVaLieu.Legends.Add(legend1);
            this.chartVaLieu.Location = new System.Drawing.Point(12, 12);
            this.chartVaLieu.Name = "chartVaLieu";
            this.chartVaLieu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVaLieu.Series.Add(series1);
            this.chartVaLieu.Size = new System.Drawing.Size(697, 589);
            this.chartVaLieu.TabIndex = 8;
            this.chartVaLieu.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Thống kê vật liệu";
            this.chartVaLieu.Titles.Add(title1);
            // 
            // frmThongKeVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 715);
            this.Controls.Add(this.chartVaLieu);
            this.Name = "frmThongKeVatLieu";
            this.Text = "Thống kê vật liệu";
            this.Load += new System.EventHandler(this.frmThongKeVatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVaLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVaLieu;
    }
}