using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.Product.Model
{
    public class ProductModel
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }

        public string FullUrl
        {
            get
            {
                return string.Format("/Product/{0}", Slug);
            }
        }

        public ProductModel(string sku,string name, int price, string image)
        {
            Sku = sku;
            Name = name;
            Price = price; 
            Image = image;
        }
    }
}
