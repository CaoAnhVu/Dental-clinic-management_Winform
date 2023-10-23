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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(109, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê";
            // 
            // chartThongKe
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend2);
            this.chartThongKe.Location = new System.Drawing.Point(115, 253);
            this.chartThongKe.Name = "chartThongKe";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Doanh thu";
            series2.Name = "Series1";
            this.chartThongKe.Series.Add(series2);
            this.chartThongKe.Size = new System.Drawing.Size(1553, 540);
            this.chartThongKe.TabIndex = 2;
            this.chartThongKe.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Thống kê doanh thu";
            this.chartThongKe.Titles.Add(title2);
            // 
            // rbDtThang
            // 
            this.rbDtThang.AutoSize = true;
            this.rbDtThang.Location = new System.Drawing.Point(6, 35);
            this.rbDtThang.Name = "rbDtThang";
            this.rbDtThang.Size = new System.Drawing.Size(96, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(115, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại thống kê";
            // 
            // rbDtQuy
            // 
            this.rbDtQuy.AutoSize = true;
            this.rbDtQuy.Location = new System.Drawing.Point(253, 35);
            this.rbDtQuy.Name = "rbDtQuy";
            this.rbDtQuy.Size = new System.Drawing.Size(85, 20);
            this.rbDtQuy.TabIndex = 6;
            this.rbDtQuy.TabStop = true;
            this.rbDtQuy.Text = "Theo quý";
            this.rbDtQuy.UseVisualStyleBackColor = true;
            this.rbDtQuy.CheckedChanged += new System.EventHandler(this.rbDtQuy_CheckedChanged);
            // 
            // rbDtNam
            // 
            this.rbDtNam.AutoSize = true;
            this.rbDtNam.Location = new System.Drawing.Point(132, 35);
            this.rbDtNam.Name = "rbDtNam";
            this.rbDtNam.Size = new System.Drawing.Size(89, 20);
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
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.label3);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
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