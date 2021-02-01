using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkHomework.Data;
using EntityFrameworkHomework.Models;

namespace EntityFrameworkHomework
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();

        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            var db = new shopDbContext();


            vendorcomboBox.DataSource = db.Vendors.Select(p => new { p.Id, p.Name }).ToList();
            vendorcomboBox.DisplayMember = "Name";
            vendorcomboBox.ValueMember = "Id";


            comboBox1.DataSource = db.Categories.Select(p => new { p.Id, p.Name }).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void urunEkle1_Click(object sender, EventArgs e)
        {

            var db = new shopDbContext();

            Product product = new Product();
            product.Name = urunName.Text;
            product.Price = Convert.ToDecimal( urunPrice.Text);
            product.Description = urunDescription.Text;
            product.ImageAddress = "";
            product.Rating = Convert.ToDouble(urunRating.Text);
            product.CategoryId = (int)comboBox1.SelectedValue;
            product.Category = db.Categories.Find((int)comboBox1.SelectedValue);
            product.VendorId = (int)vendorcomboBox.SelectedValue;
            product.Vendor = db.Vendors.Find((int)vendorcomboBox.SelectedValue);


            db.Products.Add(product);

            int rowSayisi = db.SaveChanges();

            if (rowSayisi > 0)
            {
                MessageBox.Show("Basarili");
            }
        }

        private void urunleriListele_Click(object sender, EventArgs e)
        {
            UrunleriListele listele = new UrunleriListele();
            listele.Show();
        }
    }
}
