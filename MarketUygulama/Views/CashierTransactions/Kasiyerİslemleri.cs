using MarketUygulama.HomePage;
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
    public partial class Kasiyerİslemleri : Form
    {
        public Kasiyerİslemleri()
        {
            InitializeComponent();
        }
        MarketContext db = new MarketContext();

        private void Kasiyerİslemleri_Load(object sender, EventArgs e)
        {
           var cashiers = db.Cashiers.ToList();
            dgvKasiyer.DataSource = cashiers;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KasiyerEkle frm = new KasiyerEkle();
            this.Close();
            frm.Show();
        }

        int id = 0;
        private void dgvKasiyer_DoubleClick(object sender, EventArgs e)
        {
            var secilen = dgvKasiyer.SelectedRows[0].DataBoundItem as Cashiers;
            id = secilen.CashierId;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //var silinecek = db.Cashiers.Find(id);
            var sil = dgvKasiyer.SelectedRows[0].DataBoundItem as Cashiers;
            db.Cashiers.Remove(sil);
            db.SaveChanges();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            this.Hide();
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           string search = txtSearch.Text;
            var liste = db.Cashiers.Where(c => c.KasiyerAdi.Contains(search)).ToList();
            dgvKasiyer.DataSource = liste;
        }
    }
}
