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

namespace MarketUygulama.Views.CashierTransactions
{
    public partial class KasiyerEkle : Form
    {
        public KasiyerEkle()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Cashiers cashiers = new Cashiers();
            cashiers.Adres = txtAdres.Text;
            cashiers.CepTel = mskTel.Text;
            cashiers.GorevlioldKasa = txtKasaNu.Text;
            cashiers.KasiyerAdi = txtAd.Text;
            cashiers.KasiyerSoyad = txtSoyad.Text;
            cashiers.TcKimlik = txtTc.Text;
            cashiers.İseGirmeTarihi = dtpIseGiris.Value;
            cashiers.İstenCikma = dtpIstenCikis.Value;

            db.Cashiers.Add(cashiers);
            db.SaveChanges();
               
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            Kasiyerİslemleri frm = new Kasiyerİslemleri();
            this.Close();
            frm.Show();

        }
    }
}
