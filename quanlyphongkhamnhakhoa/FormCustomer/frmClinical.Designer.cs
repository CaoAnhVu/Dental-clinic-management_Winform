namespace PKNK_CNPM.FormCustomer
{
    partial class frmClinical
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
            this.grpLamSan = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpLamSan
            // 
            this.grpLamSan.BackColor = System.Drawing.Color.Snow;
            this.grpLamSan.Location = new System.Drawing.Point(12, 12);
            this.grpLamSan.Name = "grpLamSan";
            this.grpLamSan.Size = new System.Drawing.Size(1261, 764);
            this.grpLamSan.TabIndex = 0;
            this.grpLamSan.TabStop = false;
            // 
            // frmClinical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 788);
            this.Controls.Add(this.grpLamSan);
            this.Name = "frmClinical";
            this.Text = "Lâm sàn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLamSan;
    }
}