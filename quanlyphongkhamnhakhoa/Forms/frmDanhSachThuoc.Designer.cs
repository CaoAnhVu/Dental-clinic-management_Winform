namespace PKNK_CNPM.Forms
{
    partial class frmDanhSachThuoc
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
            this.grpDanhSachThuoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpDanhSachThuoc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Thuốc";
            // 
            // grpDanhSachThuoc
            // 
            this.grpDanhSachThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSachThuoc.BackColor = System.Drawing.Color.Snow;
            this.grpDanhSachThuoc.Controls.Add(this.label2);
            this.grpDanhSachThuoc.Controls.Add(this.panel2);
            this.grpDanhSachThuoc.Controls.Add(this.txtTimKiem);
            this.grpDanhSachThuoc.Location = new System.Drawing.Point(12, 104);
            this.grpDanhSachThuoc.Name = "grpDanhSachThuoc";
            this.grpDanhSachThuoc.Size = new System.Drawing.Size(1246, 625);
            this.grpDanhSachThuoc.TabIndex = 1;
            this.grpDanhSachThuoc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "chỗ này t có làm 1 cái Item là DanhSachThuocItem nhớ add vào nha";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Location = new System.Drawing.Point(1126, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 36);
            this.panel2.TabIndex = 9;
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
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(18, 21);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(1070, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1070, 36);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Location = new System.Drawing.Point(1112, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 52);
            this.panel1.TabIndex = 8;
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
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "  Tải Lại";
            this.btnTaiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnThemThuoc);
            this.panel3.Location = new System.Drawing.Point(927, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 52);
            this.panel3.TabIndex = 7;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThemThuoc.FlatAppearance.BorderSize = 0;
            this.btnThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(-11, -10);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThemThuoc.Size = new System.Drawing.Size(197, 70);
            this.btnThemThuoc.TabIndex = 1;
            this.btnThemThuoc.Text = "    Thêm Thuốc";
            this.btnThemThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(95)))), ((int)(((byte)(99)))));
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(814, 27);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 52);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // frmDanhSachThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 753);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grpDanhSachThuoc);
            this.Controls.Add(this.label1);
            this.Name = "frmDanhSachThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Thuốc";
            this.Load += new System.EventHandler(this.frmDanhSachThuoc_Load);
            this.grpDanhSachThuoc.ResumeLayout(false);
            this.grpDanhSachThuoc.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDanhSachThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
    }
}