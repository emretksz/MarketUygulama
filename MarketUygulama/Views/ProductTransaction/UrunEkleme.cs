using MarketUygulama.Models;
using MarketUygulama.Views.ProductTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUygulama.ProductTransaction
{
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();

            Products products = new Products();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            products.AlisFiyati = txtAlisFiyat.Text;
            products.SatisFiyati = txtSatisFiyat.Text;
            products.UrunAdi = txtUrunAdi.Text;
            products.CategoryId= Convert.ToInt32(cmbKategori.SelectedValue);
            //.CategoryId = 
            products.CompanyId = Convert.ToInt32(cmbFirma.SelectedValue);
            products.UrunKodu = txtUrunKodu.Text;
            products.RegisterDate = DateTime.Now;
            products.IsActive = chkAktif.Checked ? true : false;
            db.Products.Add(products);
            db.SaveChanges();
            
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
             Random rdn = new Random();
            var random = rdn.Next(1 ,1000);
            txtUrunKodu.Text = random.ToString();
            cmbFirma.DataSource = db.Companyes.Where(p => p.IsActive == true).ToList();
            cmbFirma.DisplayMember = "Name";
            cmbFirma.ValueMember = "CompanyId";  
            cmbKategori.DataSource = db.Categories.Where(c => c.IsActive == true).ToList();
            cmbKategori.DisplayMember = "Name";
            cmbKategori.ValueMember = "CategoryId";
        }

        private void btnFirnaEkle_Click(object sender, EventArgs e)
        {
            Firma_Ekle frm = new Firma_Ekle();
            frm.Show();
            this.Hide();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle frm = new KategoriEkle();
            frm.Show();
            this.Hide();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Urunİslemleri frm = new Urunİslemleri();
            frm.Show();
            this.Close();
        }
    }
}
