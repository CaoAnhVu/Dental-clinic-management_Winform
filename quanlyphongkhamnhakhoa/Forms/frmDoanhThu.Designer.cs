namespace PKNK_CNPM.Forms
{
    partial class frmDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpDoanhThuNgay = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienThuVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTienChiRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongThuVao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongChiRa = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnAddPhieuKham = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDoanhThuNgay.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu (hôm nay)";
            // 
            // grpDoanhThuNgay
            // 
            this.grpDoanhThuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDoanhThuNgay.BackColor = System.Drawing.Color.Snow;
            this.grpDoanhThuNgay.Controls.Add(this.txtTongChiRa);
            this.grpDoanhThuNgay.Controls.Add(this.txtTongThuVao);
            this.grpDoanhThuNgay.Controls.Add(this.txtTongHoaDon);
            this.grpDoanhThuNgay.Controls.Add(this.label4);
            this.grpDoanhThuNgay.Controls.Add(this.label3);
            this.grpDoanhThuNgay.Controls.Add(this.label2);
            this.grpDoanhThuNgay.Controls.Add(this.dgvDoanhThu);
            this.grpDoanhThuNgay.Controls.Add(this.panel19);
            this.grpDoanhThuNgay.Controls.Add(this.txtTimKiem);
            this.grpDoanhThuNgay.Location = new System.Drawing.Point(12, 101);
            this.grpDoanhThuNgay.Name = "grpDoanhThuNgay";
            this.grpDoanhThuNgay.Size = new System.Drawing.Size(1198, 474);
            this.grpDoanhThuNgay.TabIndex = 1;
            this.grpDoanhThuNgay.TabStop = false;
            this.grpDoanhThuNgay.Text = "Tất cả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(694, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(205, 31);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnTimKiem);
            this.panel19.Location = new System.Drawing.Point(719, 29);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(165, 37);
            this.panel19.TabIndex = 23;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(8, 30);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(1070, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(705, 36);
            this.txtTimKiem.TabIndex = 22;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnTatCa);
            this.panel3.Location = new System.Drawing.Point(1075, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 42);
            this.panel3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAddPhieuKham);
            this.panel1.Location = new System.Drawing.Point(905, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 42);
            this.panel1.TabIndex = 35;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaHoaDon,
            this.colNgayLap,
            this.colNhanVien,
            this.colSoTienThuVao,
            this.colSoTienChiRa,
            this.colLyDo});
            this.dgvDoanhThu.Location = new System.Drawing.Point(8, 100);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1184, 226);
            this.dgvDoanhThu.TabIndex = 24;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 120;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã hóa đơn";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Width = 200;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.Width = 150;
            // 
            // colNhanVien
            // 
            this.colNhanVien.HeaderText = "Nhân viên";
            this.colNhanVien.MinimumWidth = 6;
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.Width = 150;
            // 
            // colSoTienThuVao
            // 
            this.colSoTienThuVao.HeaderText = "Số tiền thu vào";
            this.colSoTienThuVao.MinimumWidth = 6;
            this.colSoTienThuVao.Name = "colSoTienThuVao";
            this.colSoTienThuVao.Width = 170;
            // 
            // colSoTienChiRa
            // 
            this.colSoTienChiRa.HeaderText = "Số tiền chi ra";
            this.colSoTienChiRa.MinimumWidth = 6;
            this.colSoTienChiRa.Name = "colSoTienChiRa";
            this.colSoTienChiRa.Width = 150;
            // 
            // colLyDo
            // 
            this.colLyDo.HeaderText = "Lý do";
            this.colLyDo.MinimumWidth = 6;
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(27, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tổng hóa đơn";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongHoaDon.Enabled = false;
            this.txtTongHoaDon.Location = new System.Drawing.Point(181, 397);
            this.txtTongHoaDon.Multiline = true;
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(154, 29);
            this.txtTongHoaDon.TabIndex = 26;
            this.txtTongHoaDon.Text = "0";
            this.txtTongHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(387, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tổng thu vào";
            // 
            // txtTongThuVao
            // 
            this.txtTongThuVao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongThuVao.Enabled = false;
            this.txtTongThuVao.Location = new System.Drawing.Point(541, 395);
            this.txtTongThuVao.Multiline = true;
            this.txtTongThuVao.Name = "txtTongThuVao";
            this.txtTongThuVao.Size = new System.Drawing.Size(154, 29);
            this.txtTongThuVao.TabIndex = 26;
            this.txtTongThuVao.Text = "0";
            this.txtTongThuVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(749, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng chi ra";
            // 
            // txtTongChiRa
            // 
            this.txtTongChiRa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongChiRa.Enabled = false;
            this.txtTongChiRa.Location = new System.Drawing.Point(903, 393);
            this.txtTongChiRa.Multiline = true;
            this.txtTongChiRa.Name = "txtTongChiRa";
            this.txtTongChiRa.Size = new System.Drawing.Size(154, 29);
            this.txtTongChiRa.TabIndex = 26;
            this.txtTongChiRa.Text = "0";
            this.txtTongChiRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Image = global::PKNK_CNPM.Properties.Resources.reload1;
            this.btnTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTatCa.Location = new System.Drawing.Point(-11, -7);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTatCa.Size = new System.Drawing.Size(165, 58);
            this.btnTatCa.TabIndex = 3;
            this.btnTatCa.Text = "  Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            // 
            // btnAddPhieuKham
            // 
            this.btnAddPhieuKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPhieuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAddPhieuKham.FlatAppearance.BorderSize = 0;
            this.btnAddPhieuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhieuKham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnAddPhieuKham.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnAddPhieuKham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPhieuKham.Location = new System.Drawing.Point(-11, -4);
            this.btnAddPhieuKham.Name = "btnAddPhieuKham";
            this.btnAddPhieuKham.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddPhieuKham.Size = new System.Drawing.Size(190, 50);
            this.btnAddPhieuKham.TabIndex = 1;
            this.btnAddPhieuKham.Text = "    Tạo Mới";
            this.btnAddPhieuKham.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(-8, -13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(174, 63);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpDoanhThuNgay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoanhThu";
            this.Text = "Doanh Thu";
            this.grpDoanhThuNgay.ResumeLayout(false);
            this.grpDoanhThuNgay.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDoanhThuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPhieuKham;
        private System.Windows.Forms.TextBox txtTongChiRa;
        private System.Windows.Forms.TextBox txtTongThuVao;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienThuVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienChiRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLyDo;
    }
}