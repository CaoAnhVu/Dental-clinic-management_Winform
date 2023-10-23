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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVlQuy = new System.Windows.Forms.RadioButton();
            this.rbVlNam = new System.Windows.Forms.RadioButton();
            this.rbVlThang = new System.Windows.Forms.RadioButton();
            this.chartVaLieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVlQuy);
            this.groupBox2.Controls.Add(this.rbVlNam);
            this.groupBox2.Controls.Add(this.rbVlThang);
            this.groupBox2.Location = new System.Drawing.Point(106, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 61);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại thống kê";
            // 
            // rbVlQuy
            // 
            this.rbVlQuy.AutoSize = true;
            this.rbVlQuy.Location = new System.Drawing.Point(253, 35);
            this.rbVlQuy.Name = "rbVlQuy";
            this.rbVlQuy.Size = new System.Drawing.Size(85, 20);
            this.rbVlQuy.TabIndex = 6;
            this.rbVlQuy.TabStop = true;
            this.rbVlQuy.Text = "Theo quý";
            this.rbVlQuy.UseVisualStyleBackColor = true;
            // 
            // rbVlNam
            // 
            this.rbVlNam.AutoSize = true;
            this.rbVlNam.Location = new System.Drawing.Point(132, 35);
            this.rbVlNam.Name = "rbVlNam";
            this.rbVlNam.Size = new System.Drawing.Size(89, 20);
            this.rbVlNam.TabIndex = 5;
            this.rbVlNam.TabStop = true;
            this.rbVlNam.Text = "Theo năm";
            this.rbVlNam.UseVisualStyleBackColor = true;
            // 
            // rbVlThang
            // 
            this.rbVlThang.AutoSize = true;
            this.rbVlThang.Location = new System.Drawing.Point(6, 35);
            this.rbVlThang.Name = "rbVlThang";
            this.rbVlThang.Size = new System.Drawing.Size(96, 20);
            this.rbVlThang.TabIndex = 4;
            this.rbVlThang.TabStop = true;
            this.rbVlThang.Text = "Theo tháng";
            this.rbVlThang.UseVisualStyleBackColor = true;
            // 
            // chartVaLieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVaLieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVaLieu.Legends.Add(legend1);
            this.chartVaLieu.Location = new System.Drawing.Point(106, 96);
            this.chartVaLieu.Name = "chartVaLieu";
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartVaLieu);
            this.Name = "frmThongKeVatLieu";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVaLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVlQuy;
        private System.Windows.Forms.RadioButton rbVlNam;
        private System.Windows.Forms.RadioButton rbVlThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVaLieu;
    }
}