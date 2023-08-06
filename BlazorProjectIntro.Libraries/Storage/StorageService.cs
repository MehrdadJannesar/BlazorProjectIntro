using BlazorProjectIntro.Libraries.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.Storage
{
    public class StorageService : IStorageService
    {
        public IList<ProductModel> products { get; private set; }

        public ShoppingCartModel ShoppingCart { get; private set; }

        public StorageService()
        {
            products = new List<ProductModel>();
            ShoppingCart = new ShoppingCartModel();

            // Store a list of all the products for the online shop.
            AddProduct(new ProductModel("BUBBLES-GUMBALL-APRON", "A Gumball for Your Thoughts Apron", 24, "1.jpeg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-APRON", "Great Microcontrollers Think Alike Apron", 24, "2.jpeg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-BASEBALLHAT", "I Compute, Therefore I Am Baseball Hat", 29, "3.jpeg"));
            AddProduct(new ProductModel("BUBBLES-GUMBALL-BASEBALLHAT", "A Gumball for Your Thoughts Baseball Hat", 29, "4.jpg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-BASEBALLHAT", "Great Microcontrollers Think Alike Baseball Hat", 29, "5.jpeg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-MUG", "I Compute, Therefore I Am Mug", 16, "6.jpg"));
            AddProduct(new ProductModel("DOLORES-COMPUTE-TSHIRT", "I Compute, Therefore I Am T-shirt", 26, "7.jpeg"));
            AddProduct(new ProductModel("REX-MICROCONTROLLERS-TSHIRT", "Great Microcontrollers Think Alike T-shirt", 26, "8.jpeg"));
        }
        private void AddProduct(ProductModel product)
        {
            if (!products.Any(p => p.Sku == product.Sku))
            {

                products.Add(product);
            }
        }
    }
}
