using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkHomework.Models;
using EntityFrameworkHomework.Data;

namespace EntityFrameworkHomework
{
    public partial class UrunleriListele : Form
    {
        public UrunleriListele()
        {
            InitializeComponent();
        }

        private void UrunleriListele_Load(object sender, EventArgs e)
        {
            var db = new shopDbContext();
            urunlerTablosu.DataSource = Product.getProducts();

            kategorileriGor.DataSource = db.Categories.Select(p => new { p.Id, p.Name }).ToList();
            kategorileriGor.DisplayMember = "Name";
            kategorileriGor.ValueMember = "Id";
        }

        private void kategorileriGor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            urunGuncelle.Enabled = true;
            urunSil.Enabled = true;

            var db = new shopDbContext();

            int selectedCategoryId = (int)kategorileriGor.SelectedValue;
            var kategori = db.Categories.Where(y => y.Id == selectedCategoryId).FirstOrDefault();

            urunler.Text = "Seçilen Kategori: " + kategori.Name;

            var kategoriyeGoreUrunler = Product.getProductsByCategory(selectedCategoryId);        

            urunlerTablosu.DataSource = kategoriyeGoreUrunler;

            if(kategoriyeGoreUrunler.ToList().Count != 0)
            {
                urunSecCombo.DataSource = kategoriyeGoreUrunler.Select(p => new { p.Id, p.Name }).ToList();
                urunSecCombo.DisplayMember = "Name";
                urunSecCombo.ValueMember = "Id";


                int selectedProductId = (int)urunSecCombo.SelectedValue;
                var product = db.Products.Where(y => y.Id == selectedProductId).FirstOrDefault();

                urunName.Text = product.Name;
                urunPrice.Text = Convert.ToString(product.Price);
                urunRating.Text = Convert.ToString(product.Rating);
                urunDescription.Text = product.Description;
            }

            else 
            {
                urunSecCombo.DataSource = null;
                urunName.Text = "";
                urunPrice.Text = "";
                urunRating.Text = "";
                urunDescription.Text = "";
            }
          
           
        }

        private void urunGuncelle_Click(object sender, EventArgs e)
        {
            var db = new shopDbContext();

            int selectedProductId = (int)urunSecCombo.SelectedValue;
            var product = db.Products.Where(y => y.Id == selectedProductId).FirstOrDefault();

            product.Name = urunName.Text;
            product.Price = Convert.ToDecimal(urunPrice.Text);
            product.Description = urunDescription.Text;
            product.Rating = Convert.ToDouble(urunRating.Text);

            Product.Update(product);
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
          
            var db = new shopDbContext();

            int selectedProductId = (int)urunSecCombo.SelectedValue;
            var product = db.Products.Where(y => y.Id == selectedProductId).FirstOrDefault();

            db.Products.Remove(product);
            db.SaveChanges();

            int selectedCategoryId = (int)kategorileriGor.SelectedValue;
            var kategoriyeGoreUrunler = Product.getProductsByCategory(selectedCategoryId);

            urunSecCombo.DataSource = kategoriyeGoreUrunler.Select(p => new { p.Id, p.Name }).ToList();
            urunSecCombo.DisplayMember = "Name";
            urunSecCombo.ValueMember = "Id";

            urunName.Text = "";
            urunPrice.Text = "";
            urunRating.Text = "";
            urunDescription.Text = "";

            urunlerTablosu.DataSource = Product.getProductsByCategory(selectedCategoryId);

            urunGuncelle.Enabled = false;
            urunSil.Enabled = false;

        }

        private void urunSecCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            urunGuncelle.Enabled = true;
            urunSil.Enabled = true;

            var db = new shopDbContext();

            int selectedProductId = (int)urunSecCombo.SelectedValue;
            var product = db.Products.Where(y => y.Id == selectedProductId).FirstOrDefault();

            urunName.Text = product.Name;
            urunPrice.Text = Convert.ToString(product.Price);
            urunRating.Text = Convert.ToString(product.Rating);
            urunDescription.Text = product.Description;

          
        }
    }
    
}
