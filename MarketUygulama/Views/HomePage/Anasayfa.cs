using MarketUygulama.CustomerTransactions;
using MarketUygulama.Models;
using MarketUygulama.ProductTransaction;
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
            var list = db.SalesLists.Where(p => p.Products.IsActive == true);
            dgvButunList.DataSource = list;
        }

        private void dgvButunList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            this.Close();
            frm.Show();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            Urunİslemleri frm = new Urunİslemleri();
            this.Close();
            frm.Show();
        }
    }
}
