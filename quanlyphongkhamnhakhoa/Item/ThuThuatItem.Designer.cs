namespace PKNK_CNPM.FormCustomer.Controller
{
    partial class ThuThuatItem
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Snow;
            this.panel17.Controls.Add(this.lbPrice);
            this.panel17.Controls.Add(this.lbId);
            this.panel17.Controls.Add(this.lbTitle);
            this.panel17.Controls.Add(this.pbImage);
            this.panel17.Location = new System.Drawing.Point(-1, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(359, 80);
            this.panel17.TabIndex = 9;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(133, 51);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(152, 25);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Giá: 400.000 VNĐ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbId.Location = new System.Drawing.Point(133, 3);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(45, 25);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "CRV";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(133, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(113, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Cạo vôi răng";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::PKNK_CNPM.Properties.Resources.cao_voi_rang_het_bao_nhieu_768x5131;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(119, 80);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // ThuThuatItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel17);
            this.Name = "ThuThuatItem";
            this.Size = new System.Drawing.Size(359, 80);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbId;
    }
}
