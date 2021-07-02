using MarketUygulama.CustomerTransactions;
using MarketUygulama.Models;
using MarketUygulama.ProductTransaction;
using MarketUygulama.Views.CashierTransactions;
using MarketUygulama.Views.SalesTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUygulama.HomePage
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        MarketContext db = new MarketContext();
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            var list = db.SalesLists.Where(p => p.Products.IsActive == true).ToList();
            dgvButunList.DataSource = list;
        }

        private void dgvButunList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            frm.Show();
            this.Hide();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            Urunİslemleri frm = new Urunİslemleri();
            this.Hide();
            frm.Show();
        }

        private void btnKasiyer_Click(object sender, EventArgs e)
        {
            Kasiyerİslemleri frm = new Kasiyerİslemleri();
            this.Hide();
            frm.Show();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            SatisListesi frm = new SatisListesi();
            frm.Show();
            this.Hide();
        }
    }
}
