namespace PKNK_CNPM.Forms
{
    partial class FormCustomer
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
            this.dvgDanhSachKham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguonKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNVPhuTrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.grpTatCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhSachKham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTatCa
            // 
            this.grpTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTatCa.BackColor = System.Drawing.Color.Snow;
            this.grpTatCa.Controls.Add(this.dvgDanhSachKham);
            this.grpTatCa.Controls.Add(this.label2);
            this.grpTatCa.Controls.Add(this.textBox1);
            this.grpTatCa.Controls.Add(this.label3);
            this.grpTatCa.Controls.Add(this.txtTimKiem);
            this.grpTatCa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpTatCa.ForeColor = System.Drawing.Color.Black;
            this.grpTatCa.Location = new System.Drawing.Point(27, 163);
            this.grpTatCa.Name = "grpTatCa";
            this.grpTatCa.Size = new System.Drawing.Size(1223, 595);
            this.grpTatCa.TabIndex = 6;
            this.grpTatCa.TabStop = false;
            // 
            // dvgDanhSachKham
            // 
            this.dvgDanhSachKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDanhSachKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaKH,
            this.colTenKhachHang,
            this.colSDT,
            this.colDiaChi,
            this.colNguonKH,
            this.colNVPhuTrach});
            this.dvgDanhSachKham.Location = new System.Drawing.Point(6, 90);
            this.dvgDanhSachKham.Name = "dvgDanhSachKham";
            this.dvgDanhSachKham.RowHeadersWidth = 51;
            this.dvgDanhSachKham.RowTemplate.Height = 24;
            this.dvgDanhSachKham.Size = new System.Drawing.Size(1211, 410);
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
            // colMaKH
            // 
            this.colMaKH.FillWeight = 668.9839F;
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 200;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FillWeight = 28.87701F;
            this.colTenKhachHang.HeaderText = "Tên khách hàng";
            this.colTenKhachHang.MinimumWidth = 6;
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Width = 200;
            // 
            // colSDT
            // 
            this.colSDT.FillWeight = 28.87701F;
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 200;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FillWeight = 28.87701F;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 200;
            // 
            // colNguonKH
            // 
            this.colNguonKH.FillWeight = 28.87701F;
            this.colNguonKH.HeaderText = "Nguồn KH";
            this.colNguonKH.MinimumWidth = 6;
            this.colNguonKH.Name = "colNguonKH";
            this.colNguonKH.Width = 200;
            // 
            // colNVPhuTrach
            // 
            this.colNVPhuTrach.FillWeight = 28.87701F;
            this.colNVPhuTrach.HeaderText = "Nhân viên phụ trách";
            this.colNVPhuTrach.MinimumWidth = 6;
            this.colNVPhuTrach.Name = "colNVPhuTrach";
            this.colNVPhuTrach.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tất cả";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 531);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "  0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 531);
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
            this.txtTimKiem.Size = new System.Drawing.Size(1054, 36);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTaiLai);
            this.panel2.Location = new System.Drawing.Point(1123, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 52);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Location = new System.Drawing.Point(887, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 52);
            this.panel1.TabIndex = 7;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKH.Location = new System.Drawing.Point(-11, -10);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThemKH.Size = new System.Drawing.Size(248, 70);
            this.btnThemKH.TabIndex = 1;
            this.btnThemKH.Text = "    Thêm Khách Hàng";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKH.UseVisualStyleBackColor = false;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpTatCa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.grpTatCa.ResumeLayout(false);
            this.grpTatCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhSachKham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTatCa;
        private System.Windows.Forms.DataGridView dvgDanhSachKham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguonKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNVPhuTrach;
    }
}