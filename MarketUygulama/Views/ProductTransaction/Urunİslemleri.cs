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
            var product = db.Products.ToList();
            dgvUrunList.DataSource = product;
        }

        private void dgvUrunList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id = 0;
        private void dgvUrunList_DoubleClick(object sender, EventArgs e)
        {
            var selected = dgvUrunList.Rows[0].DataBoundItem as Products;
            id = selected.ProductId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkleme frm = new UrunEkleme();
            this.Close();
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var delete = dgvUrunList.SelectedRows[0].DataBoundItem as Products;
            db.Products.Remove(delete);
            db.SaveChanges();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            var searchList = db.Products.Where(f => f.UrunAdi.Contains(search)).ToList();
            dgvUrunList.DataSource = searchList;
            
        }
    }
}
