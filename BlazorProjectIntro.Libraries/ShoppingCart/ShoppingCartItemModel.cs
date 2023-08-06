using BlazorProjectIntro.Libraries.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.ShoppingCart
{
    public class ShoppingCartItemModel
    {
        public ProductModel Products { get; set; }
        public int Price { get; protected set; }
        public int Quantity { get; protected set; }
        public int TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public ShoppingCartItemModel(ProductModel products, int quantity)
        {
            Products = products;
            Price = products.Price;
            Quantity = quantity;
        }

        public void UpdateCart(ProductModel products, int quantity)
        {
            Price = products.Price;
            Quantity = quantity;
        }
    }
}
