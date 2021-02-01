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
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new shopDbContext();

            Category category = new Category();
            category.Name = textBox1.Text;
            category.Description = textBox2.Text;

            db.Categories.Add(category);
           int rowSayisi = db.SaveChanges();

            if(rowSayisi > 0)
            {
                MessageBox.Show("Basarili");
            }
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Category.getCategories();
        }

       /* private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new shopDbContext();
            var selectedProductId = (int)comboBox1.SelectedValue;
            var product = db.Products.Find(selectedProductId);
            MessageBox.Show($"{product.Name}isimli ürünün fiyatı {product.Price}");
        }*/

        private void urunEklemeButton_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }
    }
}
