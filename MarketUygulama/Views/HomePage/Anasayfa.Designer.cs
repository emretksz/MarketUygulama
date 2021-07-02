namespace MarketUygulama.HomePage
{
    partial class Anasayfa
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
            this.btnMusteriIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnKasiyer = new System.Windows.Forms.Button();
            this.btnStockIslem = new System.Windows.Forms.Button();
            this.btnSatisIslemleri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvButunList = new System.Windows.Forms.DataGridView();
            this.lblSatisListesi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvButunList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriIslemleri
            // 
            this.btnMusteriIslemleri.Location = new System.Drawing.Point(62, 32);
            this.btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            this.btnMusteriIslemleri.Size = new System.Drawing.Size(100, 54);
            this.btnMusteriIslemleri.TabIndex = 0;
            this.btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            this.btnMusteriIslemleri.UseVisualStyleBackColor = true;
            this.btnMusteriIslemleri.Click += new System.EventHandler(this.btnMusteriIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.Location = new System.Drawing.Point(183, 32);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(91, 54);
            this.btnUrunIslemleri.TabIndex = 0;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = true;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnKasiyer
            // 
            this.btnKasiyer.Location = new System.Drawing.Point(304, 32);
            this.btnKasiyer.Name = "btnKasiyer";
            this.btnKasiyer.Size = new System.Drawing.Size(92, 54);
            this.btnKasiyer.TabIndex = 0;
            this.btnKasiyer.Text = "Kasiyer İşlemleri";
            this.btnKasiyer.UseVisualStyleBackColor = true;
            this.btnKasiyer.Click += new System.EventHandler(this.btnKasiyer_Click);
            // 
            // btnStockIslem
            // 
            this.btnStockIslem.Location = new System.Drawing.Point(428, 31);
            this.btnStockIslem.Name = "btnStockIslem";
            this.btnStockIslem.Size = new System.Drawing.Size(87, 55);
            this.btnStockIslem.TabIndex = 0;
            this.btnStockIslem.Text = "Stok İşlemleri";
            this.btnStockIslem.UseVisualStyleBackColor = true;
            // 
            // btnSatisIslemleri
            // 
            this.btnSatisIslemleri.Location = new System.Drawing.Point(546, 32);
            this.btnSatisIslemleri.Name = "btnSatisIslemleri";
            this.btnSatisIslemleri.Size = new System.Drawing.Size(94, 54);
            this.btnSatisIslemleri.TabIndex = 0;
            this.btnSatisIslemleri.Text = "Satış İşlemleri";
            this.btnSatisIslemleri.UseVisualStyleBackColor = true;
            this.btnSatisIslemleri.Click += new System.EventHandler(this.btnSatisIslemleri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(669, 32);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(97, 54);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(691, 164);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 43);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(485, 187);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // dgvButunList
            // 
            this.dgvButunList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvButunList.Location = new System.Drawing.Point(27, 228);
            this.dgvButunList.Name = "dgvButunList";
            this.dgvButunList.Size = new System.Drawing.Size(729, 210);
            this.dgvButunList.TabIndex = 3;
            this.dgvButunList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvButunList_CellContentClick);
            // 
            // lblSatisListesi
            // 
            this.lblSatisListesi.AutoSize = true;
            this.lblSatisListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisListesi.Location = new System.Drawing.Point(280, 182);
            this.lblSatisListesi.Name = "lblSatisListesi";
            this.lblSatisListesi.Size = new System.Drawing.Size(116, 25);
            this.lblSatisListesi.TabIndex = 4;
            this.lblSatisListesi.Text = "Satış Listesi";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSatisListesi);
            this.Controls.Add(this.dgvButunList);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSatisIslemleri);
            this.Controls.Add(this.btnStockIslem);
            this.Controls.Add(this.btnKasiyer);
            this.Controls.Add(this.btnUrunIslemleri);
            this.Controls.Add(this.btnMusteriIslemleri);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvButunList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnKasiyer;
        private System.Windows.Forms.Button btnStockIslem;
        private System.Windows.Forms.Button btnSatisIslemleri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridView dgvButunList;
        private System.Windows.Forms.Label lblSatisListesi;
    }
}