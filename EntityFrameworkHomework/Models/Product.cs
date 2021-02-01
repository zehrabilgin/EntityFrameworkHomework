using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkHomework.Data;

namespace EntityFrameworkHomework.Models
{
   public class Product
    {
        public int Id { get; set; }
        public string ImageAddress { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string ProductInfos { get; set; }
        
        public Vendor Vendor { get; set; }
        public int? VendorId { get; set; }

        public static IList<Product> getProducts()
        {
            var db = new shopDbContext();
            return db.Products.ToList();
        }

        public static IList<Product> getProductsByCategory(int catId)
        {
            var db = new shopDbContext();
            return db.Products.Where(s => s.CategoryId == catId).ToList() ;


        }

        public static void Update(Product product)
        {
            var db = new shopDbContext();
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
