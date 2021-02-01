using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkHomework.Data;

namespace EntityFrameworkHomework.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property:baska bir kategoriye gidisi kolaylastiriyor
        public IList<Product> Products { get; set; }

        public static IList<Category> getCategories()
        {
            var db = new shopDbContext();
            return db.Categories.ToList();

            ///dataGridView1.DataSource = db.Categories.ToList();
        }

    }
}
