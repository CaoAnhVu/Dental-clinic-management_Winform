namespace PKNK_CNPM.FormsSetting
{
    partial class frmDanhSachNV
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
            this.grpTatCa = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpTatCa.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Nhân Viên";
            // 
            // grpTatCa
            // 
            this.grpTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTatCa.BackColor = System.Drawing.Color.Snow;
            this.grpTatCa.Controls.Add(this.panel3);
            this.grpTatCa.Controls.Add(this.dgvNhanVien);
            this.grpTatCa.Controls.Add(this.txtTong);
            this.grpTatCa.Controls.Add(this.label2);
            this.grpTatCa.Controls.Add(this.txtTimKiem);
            this.grpTatCa.Controls.Add(this.label1);
            this.grpTatCa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpTatCa.ForeColor = System.Drawing.Color.Black;
            this.grpTatCa.Location = new System.Drawing.Point(19, 310);
            this.grpTatCa.Name = "grpTatCa";
            this.grpTatCa.Size = new System.Drawing.Size(1144, 509);
            this.grpTatCa.TabIndex = 4;
            this.grpTatCa.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Location = new System.Drawing.Point(592, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 37);
            this.panel3.TabIndex = 20;
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
            this.btnTimKiem.Location = new System.Drawing.Point(-9, -13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(174, 63);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.ChucDanh,
            this.NamSinh,
            this.SoDienThoai,
            this.Email,
            this.DiaChi,
            this.GioiTinh});
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 96);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1118, 344);
            this.dgvNhanVien.TabIndex = 5;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDanhSachKham_CellContentClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Frozen = true;
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 170;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 200;
            // 
            // ChucDanh
            // 
            this.ChucDanh.HeaderText = "Chức vụ";
            this.ChucDanh.MinimumWidth = 6;
            this.ChucDanh.Name = "ChucDanh";
            this.ChucDanh.Width = 150;
            // 
            // NamSinh
            // 
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.MinimumWidth = 6;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 120;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // txtTong
            // 
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(90, 470);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(186, 32);
            this.txtTong.TabIndex = 3;
            this.txtTong.Text = "  0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(16, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(570, 37);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnThemNV);
            this.panel1.Location = new System.Drawing.Point(787, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 52);
            this.panel1.TabIndex = 5;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(-11, -10);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThemNV.Size = new System.Drawing.Size(248, 70);
            this.btnThemNV.TabIndex = 1;
            this.btnThemNV.Text = "    Thêm Nhân Viên";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTaiLai);
            this.panel2.Location = new System.Drawing.Point(1023, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 52);
            this.panel2.TabIndex = 6;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Image = global::PKNK_CNPM.Properties.Resources.reload1;
            this.btnTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiLai.Location = new System.Drawing.Point(-10, -3);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTaiLai.Size = new System.Drawing.Size(142, 58);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "  Tải Lại";
            this.btnTaiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(19, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1015, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(116, 53);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(195, 49);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(391, 38);
            this.txtMaNV.TabIndex = 17;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(195, 104);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(391, 38);
            this.txtChucVu.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(26, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(643, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(812, 49);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(391, 38);
            this.txtTenNV.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(26, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã nhân viên";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(95)))), ((int)(((byte)(99)))));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(657, 26);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 52);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 1055);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTatCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachNV";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            this.grpTatCa.ResumeLayout(false);
            this.grpTatCa.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.GroupBox grpTatCa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}