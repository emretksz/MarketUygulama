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
    public partial class Urunİslemleri : Form
    {
        public Urunİslemleri()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();
        private void Urunİslemleri_Load(object sender, EventArgs e)
        {
            var urun = db.Products.ToList();
            dgvUrunList.DataSource = urun;
        }

        private void dgvUrunList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id = 0;
        private void dgvUrunList_DoubleClick(object sender, EventArgs e)
        {
            var secili = dgvUrunList.Rows[0].DataBoundItem as Products;
            id = secili.ProductId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme frm = new UrunEkleme();
            this.Close();
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
