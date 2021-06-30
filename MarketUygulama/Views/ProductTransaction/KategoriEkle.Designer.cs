namespace MarketUygulama.Views.ProductTransaction
{
    partial class KategoriEkle
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
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.dgvKategori = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDon = new System.Windows.Forms.Button();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(103, 351);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(241, 20);
            this.txtEkle.TabIndex = 7;
            // 
            // dgvKategori
            // 
            this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategori.Location = new System.Drawing.Point(45, 179);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.Size = new System.Drawing.Size(355, 150);
            this.dgvKategori.TabIndex = 6;
            this.dgvKategori.DoubleClick += new System.EventHandler(this.dgvKategori_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(255, 392);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 25);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(151, 394);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 20);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDon
            // 
            this.btnDon.Location = new System.Drawing.Point(45, 33);
            this.btnDon.Name = "btnDon";
            this.btnDon.Size = new System.Drawing.Size(75, 23);
            this.btnDon.TabIndex = 5;
            this.btnDon.Text = "Geri Dön";
            this.btnDon.UseVisualStyleBackColor = true;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(376, 354);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(67, 17);
            this.chkAktif.TabIndex = 8;
            this.chkAktif.Text = "Aktif Mi?";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 504);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.dgvKategori);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDon);
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.Load += new System.EventHandler(this.KategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.DataGridView dgvKategori;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDon;
        private System.Windows.Forms.CheckBox chkAktif;
    }
}