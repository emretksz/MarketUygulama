﻿using MarketUygulama.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketUygulama.Views.ProductTransaction
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        MarketContext db = new MarketContext();
        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            dgvKategori.DataSource = db.Categories.Where(c => c.IsActive == true).ToList() ;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Categories add = new Categories();
            add.Name = txtEkle.Text;
            add.IsActive = chkAktif.Checked ? true : false;
            db.Categories.Add(add);
            db.SaveChanges();
        }
        int id = 0;
        private void dgvKategori_DoubleClick(object sender, EventArgs e)
        {
            var sonuc = dgvKategori.SelectedRows[0].DataBoundItem as Categories;
            id = sonuc.CategoryId;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
         
            var delete = db.Categories.Find(id);
            db.Categories.Remove(delete);
            db.SaveChanges();
            
        }
    }
}
