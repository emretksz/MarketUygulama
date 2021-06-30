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

namespace MarketUygulama.CustomerTransactions
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();
        private void Musteriler_Load(object sender, EventArgs e)
        {
            var liste = db.Customers.ToList();
            dgvMusteriler.DataSource = liste;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle frm = new MusteriEkle();
            this.Hide();
            frm.Show();
        }

        int id = 0;
        private void dgvMusteriler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var delete = dgvMusteriler.SelectedRows[0].DataBoundItem as Customers;
            id = delete.CustomerId;
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var delete = db.Customers.Find(id);
            db.Customers.Remove(delete);
            db.SaveChanges();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var sonuc = db.Customers.Where(p => p.MusteriAdi.Contains(search)).ToList();
            dgvMusteriler.DataSource = sonuc;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            this.Close();
            frm.Show();
        }
    }
}
