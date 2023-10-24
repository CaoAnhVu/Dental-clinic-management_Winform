namespace PKNK_CNPM.Forms
{
    partial class frmThongKe
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
            this.label3 = new System.Windows.Forms.Label();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbDtThang = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDtQuy = new System.Windows.Forms.RadioButton();
            this.rbDtNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê";
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(12, 190);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            series1.Legend = "Legend1";
            series1.LegendText = "Doanh thu";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(1739, 696);
            this.chartThongKe.TabIndex = 2;
            this.chartThongKe.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Thống kê doanh thu";
            this.chartThongKe.Titles.Add(title1);
            // 
            // rbDtThang
            // 
            this.rbDtThang.AutoSize = true;
            this.rbDtThang.Location = new System.Drawing.Point(6, 35);
            this.rbDtThang.Name = "rbDtThang";
            this.rbDtThang.Size = new System.Drawing.Size(132, 32);
            this.rbDtThang.TabIndex = 4;
            this.rbDtThang.TabStop = true;
            this.rbDtThang.Text = "Theo tháng";
            this.rbDtThang.UseVisualStyleBackColor = true;
            this.rbDtThang.CheckedChanged += new System.EventHandler(this.rbDtThang_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDtQuy);
            this.groupBox1.Controls.Add(this.rbDtNam);
            this.groupBox1.Controls.Add(this.rbDtThang);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại thống kê";
            // 
            // rbDtQuy
            // 
            this.rbDtQuy.AutoSize = true;
            this.rbDtQuy.Location = new System.Drawing.Point(495, 33);
            this.rbDtQuy.Name = "rbDtQuy";
            this.rbDtQuy.Size = new System.Drawing.Size(114, 32);
            this.rbDtQuy.TabIndex = 6;
            this.rbDtQuy.TabStop = true;
            this.rbDtQuy.Text = "Theo quý";
            this.rbDtQuy.UseVisualStyleBackColor = true;
            this.rbDtQuy.CheckedChanged += new System.EventHandler(this.rbDtQuy_CheckedChanged);
            // 
            // rbDtNam
            // 
            this.rbDtNam.AutoSize = true;
            this.rbDtNam.Location = new System.Drawing.Point(251, 33);
            this.rbDtNam.Name = "rbDtNam";
            this.rbDtNam.Size = new System.Drawing.Size(119, 32);
            this.rbDtNam.TabIndex = 5;
            this.rbDtNam.TabStop = true;
            this.rbDtNam.Text = "Theo năm";
            this.rbDtNam.UseVisualStyleBackColor = true;
            this.rbDtNam.CheckedChanged += new System.EventHandler(this.rbDtNam_CheckedChanged);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.label3);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.RadioButton rbDtThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDtQuy;
        private System.Windows.Forms.RadioButton rbDtNam;
    }
}