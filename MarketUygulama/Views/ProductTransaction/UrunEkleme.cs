using MarketUygulama.Models;
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            var random =rdn.Next(1 - 1000);
            Products products = new Products();
            products.AlisFiyati = txtAlisFiyat.Text;
            products.SatisFiyati = txtSatisFiyat.Text;
            products.UrunAdi = txtUrunAdi.Text;
            products.Categories.Name = cmbKategori.SelectedItem.ToString();
            products.Companyes.Name = cmbFirma.SelectedItem.ToString();
            products.UrunKodu = random.ToString();
            products.RegisterDate = DateTime.Now;
            products.IsActive = chkAktif.Checked ? true : false;
            db.Products.Add(products);
            db.SaveChanges();
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {
         
            cmbFirma.DataSource = db.Companyes.Where(p => p.IsActive == true);
            cmbFirma.DisplayMember = "Name";
            cmbFirma.ValueMember = "CompanyId";  
            cmbKategori.DataSource = db.Categories.Where(c => c.IsActive == true);
            cmbKategori.DisplayMember = "Name";
            cmbKategori.SelectedValue = "CategoryId";
        }
    }
}
