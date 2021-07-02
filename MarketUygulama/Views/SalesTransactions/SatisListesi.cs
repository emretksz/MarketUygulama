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

namespace MarketUygulama.Views.SalesTransactions
{
    public partial class SatisListesi : Form
    {
        public SatisListesi()
        {
            InitializeComponent();
        }
        MarketContext db = new MarketContext();
        private void SatisListesi_Load(object sender, EventArgs e)
        {
            dgvSatisListesi.DataSource = db.Customers.ToList();
        }

        int id = 0;
        private void dgvSatisListesi_DoubleClick(object sender, EventArgs e)
        {
            var selected = dgvSatisListesi.SelectedRows[0].DataBoundItem as Customers;
            txtMusteriAdi.Text = selected.MusteriAdi;
            txtSoyad.Text = selected.MusteriSoyadi;
            txtTc.Text = selected.TcNu;
            
            cmbKasiyer.DataSource = db.Cashiers.ToList();
                cmbKasiyer.DisplayMember = "KasiyerAdi";
            cmbKasiyer.ValueMember = "CashierId";
            cmbUrunAdi.DataSource = db.Products.Where(p => p.IsActive == true).ToList();
            
            id = selected.CustomerId;
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Customers customers = db.Customers.Find(id);
            SalesLists salesLists = new SalesLists();
            salesLists.MusteriAdi = txtMusteriAdi.Text;
            salesLists.MusteriSoyAdi = txtSoyad.Text;
            salesLists.KasaNu = txtKasaNu.Text;
            salesLists.Adet = txtAdet.Text;
            salesLists.CashierId = Convert.ToInt32(cmbKasiyer.SelectedValue);
            salesLists.CustomerId = customers.CustomerId;
            salesLists.FaturaNu = txtFatura.Text;
            //salesLists.ProductId = Convert.ToInt32(cmbUrunAdi.SelectedValue);
            salesLists.Tarih = dtpTarih.Value;
               var urun= db.Products.Find(id);
            salesLists.ProductId = urun.ProductId;
            salesLists.TcNu = txtTc.Text;
            int sonFiyat = 0;
            if (urun.SatisFiyati!=null)
            {
                 sonFiyat = Convert.ToInt32(urun.SatisFiyati);
            }
            salesLists.ToplamTutar = sonFiyat.ToString();
            salesLists.UrunAdi = cmbUrunAdi.SelectedItem.ToString();
            db.SalesLists.Add(salesLists);
            db.SaveChanges();
            dgvSatisListesi.DataSource = db.SalesLists.ToList();
        }
    }
}
