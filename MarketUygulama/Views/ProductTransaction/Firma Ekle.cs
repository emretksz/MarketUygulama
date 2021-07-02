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
    public partial class Firma_Ekle : Form
    {
        public Firma_Ekle()
        {
            InitializeComponent();
        }
        MarketContext db = new MarketContext();
        private void Firma_Ekle_Load(object sender, EventArgs e)
        {
            var list = db.Companyes.Where(u => u.IsActive == true).ToList();
            dgvFirma.DataSource = list;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Companyes companyes = new Companyes();
            companyes.Name = txtEkle.Text;
            companyes.IsActive = chkIsActive.Checked ? true : false;
            db.Companyes.Add(companyes);
            db.SaveChanges();
            dgvFirma.DataSource = db.Companyes.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var delete = dgvFirma.SelectedRows[0].DataBoundItem as Companyes;
            db.Companyes.Remove(delete);
            db.SaveChanges();
            dgvFirma.DataSource = db.Companyes.ToList();

        }
    }
}
