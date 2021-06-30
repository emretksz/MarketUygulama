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

namespace MarketUygulama.CustomerTransactions
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Adres = txtAdres.Text;
            customers.CepTel = mskTel.Text;
            customers.EvTel = "";
            customers.MusteriAdi = txtAd.Text;
            customers.MusteriSoyadi = txtSoyad.Text;
            customers.TcNu = txtTc.Text;
            db.Customers.Add(customers);
            db.SaveChanges();


            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            this.Close();
            frm.Show();
        }
    }
}
