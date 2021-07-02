namespace MarketUygulama.ProductTransaction
{
    partial class Firma_Ekle
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
            this.btnDon = new System.Windows.Forms.Button();
            this.dgvFirma = new System.Windows.Forms.DataGridView();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(12, 28);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(75, 23);
            this.btnDon.TabIndex = 0;
            this.btnDon.Text = "Geri Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            // 
            // dgvFirma
            // 
            this.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirma.Location = new System.Drawing.Point(91, 80);
            this.dgvFirma.Name = "dgvFirma";
            this.dgvFirma.Size = new System.Drawing.Size(355, 150);
            this.dgvFirma.TabIndex = 1;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(131, 262);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(249, 20);
            this.txtEkle.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(131, 308);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(251, 308);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 28);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(395, 264);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(66, 17);
            this.chkIsActive.TabIndex = 3;
            this.chkIsActive.Text = "Aktif mi?";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // Firma_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 443);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.dgvFirma);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDon);
            this.Name = "Firma_Ekle";
            this.Text = "Firma_Ekle";
            this.Load += new System.EventHandler(this.Firma_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.DataGridView dgvFirma;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}