namespace PKNK_CNPM.Item
{
    partial class TTThuThuatItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBacSi = new System.Windows.Forms.ComboBox();
            this.cbLoaiTT = new System.Windows.Forms.ComboBox();
            this.picXoa = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtGG = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtVatLieu = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtThuThuat = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBacSi
            // 
            this.cbBacSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBacSi.FormattingEnabled = true;
            this.cbBacSi.Location = new System.Drawing.Point(324, 43);
            this.cbBacSi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBacSi.Name = "cbBacSi";
            this.cbBacSi.Size = new System.Drawing.Size(233, 36);
            this.cbBacSi.TabIndex = 76;
            // 
            // cbLoaiTT
            // 
            this.cbLoaiTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiTT.FormattingEnabled = true;
            this.cbLoaiTT.Location = new System.Drawing.Point(118, 43);
            this.cbLoaiTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiTT.Name = "cbLoaiTT";
            this.cbLoaiTT.Size = new System.Drawing.Size(198, 36);
            this.cbLoaiTT.TabIndex = 75;
            this.cbLoaiTT.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTT_SelectedIndexChanged_1);
            // 
            // picXoa
            // 
            this.picXoa.Image = global::PKNK_CNPM.Properties.Resources.delete;
            this.picXoa.Location = new System.Drawing.Point(1061, 5);
            this.picXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picXoa.Name = "picXoa";
            this.picXoa.Size = new System.Drawing.Size(51, 42);
            this.picXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXoa.TabIndex = 74;
            this.picXoa.TabStop = false;
            this.picXoa.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1120, 3);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 73;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtGG
            // 
            this.txtGG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGG.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGG.Location = new System.Drawing.Point(790, 43);
            this.txtGG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGG.Multiline = true;
            this.txtGG.Name = "txtGG";
            this.txtGG.Size = new System.Drawing.Size(48, 33);
            this.txtGG.TabIndex = 66;
            this.txtGG.Text = "0";
            this.txtGG.TextChanged += new System.EventHandler(this.txtGG_TextChanged_1);
            this.txtGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGG_KeyPress_1);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(790, 2);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(48, 34);
            this.txtSoLuong.TabIndex = 67;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged_1);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress_1);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(846, 43);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(207, 33);
            this.txtThanhTien.TabIndex = 68;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(846, 2);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(207, 34);
            this.txtDonGia.TabIndex = 69;
            // 
            // txtVatLieu
            // 
            this.txtVatLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVatLieu.Enabled = false;
            this.txtVatLieu.Location = new System.Drawing.Point(565, 43);
            this.txtVatLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVatLieu.Multiline = true;
            this.txtVatLieu.Name = "txtVatLieu";
            this.txtVatLieu.Size = new System.Drawing.Size(217, 33);
            this.txtVatLieu.TabIndex = 70;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Location = new System.Drawing.Point(565, 2);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(217, 34);
            this.txtNoiDung.TabIndex = 71;
            // 
            // txtThuThuat
            // 
            this.txtThuThuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThuThuat.Enabled = false;
            this.txtThuThuat.Location = new System.Drawing.Point(324, 2);
            this.txtThuThuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThuThuat.Multiline = true;
            this.txtThuThuat.Name = "txtThuThuat";
            this.txtThuThuat.Size = new System.Drawing.Size(233, 34);
            this.txtThuThuat.TabIndex = 72;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgay.Location = new System.Drawing.Point(118, 2);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgay.MaxDate = new System.DateTime(2023, 10, 19, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(198, 34);
            this.dtpNgay.TabIndex = 65;
            this.dtpNgay.Value = new System.DateTime(2023, 10, 19, 0, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.label17.Location = new System.Drawing.Point(4, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 23);
            this.label17.TabIndex = 64;
            this.label17.Text = "Thủ thuật";
            // 
            // TTThuThuatItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.cbBacSi);
            this.Controls.Add(this.cbLoaiTT);
            this.Controls.Add(this.picXoa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtGG);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtVatLieu);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtThuThuat);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label17);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TTThuThuatItem";
            this.Size = new System.Drawing.Size(1142, 81);
            this.Load += new System.EventHandler(this.TTThuThuatItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBacSi;
        private System.Windows.Forms.ComboBox cbLoaiTT;
        private System.Windows.Forms.PictureBox picXoa;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtGG;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtVatLieu;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtThuThuat;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label17;
    }
}
