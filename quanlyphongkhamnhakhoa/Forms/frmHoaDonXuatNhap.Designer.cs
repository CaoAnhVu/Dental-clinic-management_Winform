namespace PKNK_CNPM.Forms
{
    partial class frmHoaDonXuatNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienTruocThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienSauThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Xuất Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 448);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col,
            this.colMaHoaDon,
            this.colNgayLap,
            this.colSoLuong,
            this.colTienTruocThue,
            this.colTienThue,
            this.colTienSauThue,
            this.colTienNo});
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 343);
            this.dataGridView1.TabIndex = 22;
            // 
            // col
            // 
            this.col.HeaderText = "STT";
            this.col.MinimumWidth = 6;
            this.col.Name = "col";
            this.col.Width = 50;
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
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 50;
            // 
            // colTienTruocThue
            // 
            this.colTienTruocThue.HeaderText = "Tiền trước thuế";
            this.colTienTruocThue.MinimumWidth = 6;
            this.colTienTruocThue.Name = "colTienTruocThue";
            this.colTienTruocThue.Width = 200;
            // 
            // colTienThue
            // 
            this.colTienThue.HeaderText = "Tiền thuế";
            this.colTienThue.MinimumWidth = 6;
            this.colTienThue.Name = "colTienThue";
            this.colTienThue.Width = 125;
            // 
            // colTienSauThue
            // 
            this.colTienSauThue.HeaderText = "Tiền sau thuế";
            this.colTienSauThue.MinimumWidth = 6;
            this.colTienSauThue.Name = "colTienSauThue";
            this.colTienSauThue.Width = 200;
            // 
            // colTienNo
            // 
            this.colTienNo.HeaderText = "Tiền nợ";
            this.colTienNo.MinimumWidth = 6;
            this.colTienNo.Name = "colTienNo";
            this.colTienNo.Width = 150;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::PKNK_CNPM.Properties.Resources.add1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(517, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(174, 36);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 21);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(1070, 36);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(505, 36);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.Text = "   Tìm kiếm...";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTaiLai);
            this.panel2.Location = new System.Drawing.Point(1075, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 52);
            this.panel2.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnThemKH);
            this.panel1.Location = new System.Drawing.Point(868, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 52);
            this.panel1.TabIndex = 9;
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
            this.btnThemKH.Location = new System.Drawing.Point(-8, -10);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThemKH.Size = new System.Drawing.Size(216, 70);
            this.btnThemKH.TabIndex = 1;
            this.btnThemKH.Text = "    Thêm Hóa Đơn";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKH.UseVisualStyleBackColor = false;
            // 
            // frmHoaDonXuatNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonXuatNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Xuất Nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienTruocThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienSauThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienNo;
    }
}