﻿namespace PKNK_CNPM.Forms
{
    partial class frmPhieuKham
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
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTienGiam = new System.Windows.Forms.TextBox();
            this.txtKhachCanTra = new System.Windows.Forms.TextBox();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.btnLuuLai.FlatAppearance.BorderSize = 0;
            this.btnLuuLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuLai.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLai.ForeColor = System.Drawing.Color.White;
            this.btnLuuLai.Location = new System.Drawing.Point(12, 340);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(344, 50);
            this.btnLuuLai.TabIndex = 17;
            this.btnLuuLai.Text = "Đã thanh toán";
            this.btnLuuLai.UseVisualStyleBackColor = false;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Silver;
            this.btnInHoaDon.Enabled = false;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Image = global::PKNK_CNPM.Properties.Resources.printing1;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(12, 396);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(344, 41);
            this.btnInHoaDon.TabIndex = 18;
            this.btnInHoaDon.Text = "     In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tiền giảm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 25);
            this.label19.TabIndex = 8;
            this.label19.Text = "Khách cần trả";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(24)))), ((int)(((byte)(162)))));
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 32);
            this.label20.TabIndex = 8;
            this.label20.Text = "Thanh Toán";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(7, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 2);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(7, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 2);
            this.label7.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(6, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(330, 2);
            this.label14.TabIndex = 9;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Snow;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTongTien.Location = new System.Drawing.Point(136, 47);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 25);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.Text = "  0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienGiam
            // 
            this.txtTienGiam.BackColor = System.Drawing.Color.Snow;
            this.txtTienGiam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienGiam.Enabled = false;
            this.txtTienGiam.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTienGiam.Location = new System.Drawing.Point(136, 100);
            this.txtTienGiam.Name = "txtTienGiam";
            this.txtTienGiam.Size = new System.Drawing.Size(150, 25);
            this.txtTienGiam.TabIndex = 12;
            this.txtTienGiam.Text = "0";
            this.txtTienGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKhachCanTra
            // 
            this.txtKhachCanTra.BackColor = System.Drawing.Color.Snow;
            this.txtKhachCanTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhachCanTra.Enabled = false;
            this.txtKhachCanTra.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKhachCanTra.Location = new System.Drawing.Point(136, 149);
            this.txtKhachCanTra.Name = "txtKhachCanTra";
            this.txtKhachCanTra.Size = new System.Drawing.Size(150, 25);
            this.txtKhachCanTra.TabIndex = 12;
            this.txtKhachCanTra.Text = "0";
            this.txtKhachCanTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.Snow;
            this.txtThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThanhToan.Enabled = false;
            this.txtThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtThanhToan.Location = new System.Drawing.Point(158, 193);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(128, 25);
            this.txtThanhToan.TabIndex = 12;
            this.txtThanhToan.Text = "0";
            this.txtThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtThanhToan);
            this.groupBox2.Controls.Add(this.txtKhachCanTra);
            this.groupBox2.Controls.Add(this.txtTienGiam);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 290);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(292, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(293, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(292, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(292, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 2);
            this.label3.TabIndex = 7;
            // 
            // frmPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 456);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frmPhieuKham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTienGiam;
        private System.Windows.Forms.TextBox txtKhachCanTra;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}