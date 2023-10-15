namespace PKNK_CNPM.FormCustomer
{
    partial class frmExaminationform
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
            this.grpTatCa = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dvgDanhSachKham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoPhieuKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPhieuKham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.grpTatCa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhSachKham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTatCa
            // 
            this.grpTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTatCa.BackColor = System.Drawing.Color.Snow;
            this.grpTatCa.Controls.Add(this.panel2);
            this.grpTatCa.Controls.Add(this.dvgDanhSachKham);
            this.grpTatCa.Controls.Add(this.txtTong);
            this.grpTatCa.Controls.Add(this.label3);
            this.grpTatCa.Controls.Add(this.txtTimKiem);
            this.grpTatCa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpTatCa.ForeColor = System.Drawing.Color.Black;
            this.grpTatCa.Location = new System.Drawing.Point(12, 105);
            this.grpTatCa.Name = "grpTatCa";
            this.grpTatCa.Size = new System.Drawing.Size(1265, 507);
            this.grpTatCa.TabIndex = 6;
            this.grpTatCa.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Location = new System.Drawing.Point(721, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 36);
            this.panel2.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(-8, -3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 39);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dvgDanhSachKham
            // 
            this.dvgDanhSachKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDanhSachKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colSoPhieuKham,
            this.colBacSi,
            this.colKhachHang,
            this.colSDT,
            this.colThuThuat,
            this.colTrangThai,
            this.colGhiChu});
            this.dvgDanhSachKham.Location = new System.Drawing.Point(6, 90);
            this.dvgDanhSachKham.Name = "dvgDanhSachKham";
            this.dvgDanhSachKham.RowHeadersWidth = 51;
            this.dvgDanhSachKham.RowTemplate.Height = 24;
            this.dvgDanhSachKham.Size = new System.Drawing.Size(1253, 322);
            this.dvgDanhSachKham.TabIndex = 4;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 28.87701F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colSoPhieuKham
            // 
            this.colSoPhieuKham.FillWeight = 668.9839F;
            this.colSoPhieuKham.HeaderText = "Số phiếu khám";
            this.colSoPhieuKham.MinimumWidth = 6;
            this.colSoPhieuKham.Name = "colSoPhieuKham";
            this.colSoPhieuKham.Width = 200;
            // 
            // colBacSi
            // 
            this.colBacSi.FillWeight = 28.87701F;
            this.colBacSi.HeaderText = "Bác sĩ";
            this.colBacSi.MinimumWidth = 6;
            this.colBacSi.Name = "colBacSi";
            this.colBacSi.Width = 200;
            // 
            // colKhachHang
            // 
            this.colKhachHang.FillWeight = 28.87701F;
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.MinimumWidth = 6;
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.Width = 200;
            // 
            // colSDT
            // 
            this.colSDT.FillWeight = 28.87701F;
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 150;
            // 
            // colThuThuat
            // 
            this.colThuThuat.FillWeight = 28.87701F;
            this.colThuThuat.HeaderText = "Thủ thuật";
            this.colThuThuat.MinimumWidth = 6;
            this.colThuThuat.Name = "colThuThuat";
            this.colThuThuat.Width = 150;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 28.87701F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 125;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FillWeight = 28.87701F;
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 200;
            // 
            // txtTong
            // 
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTong.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(100, 443);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(186, 25);
            this.txtTong.TabIndex = 3;
            this.txtTong.Text = "  0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 44);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(1070, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(700, 36);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phiếu Khám (hôm nay)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAddPhieuKham);
            this.panel1.Location = new System.Drawing.Point(982, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 42);
            this.panel1.TabIndex = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tất cả";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnTatCa);
            this.panel3.Location = new System.Drawing.Point(1153, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 42);
            this.panel3.TabIndex = 31;
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
            // frmExaminationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTatCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmExaminationform";
            this.Text = "Phiếu khám";
            this.grpTatCa.ResumeLayout(false);
            this.grpTatCa.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhSachKham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTatCa;
        private System.Windows.Forms.DataGridView dvgDanhSachKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoPhieuKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPhieuKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTatCa;
    }
}