using BlazorProjectIntro.Libraries.Product.Model;
using BlazorProjectIntro.Libraries.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IStorageService _storageService;

        public ShoppingCartService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void AddProduct(ProductModel product, int quantity)
        {
            var items = Get().Items;
            if (HasProduct(product.Sku))
            {
                var item = items.First(i => i.Products.Sku == product.Sku);
                item.UpdateCart(product, item.Quantity + quantity);
            }
            else
            {
                items.Add(new ShoppingCartItemModel(product, quantity));
            }
        }

        public void RemoveProduct(ProductModel product, int quantity)
        {
            var items = Get().Items;
            if (HasProduct(product.Sku))
            {
                if (CountOfItem(product.Sku) >= 1)
                {
                    var item = items.First(i => i.Products.Sku == product.Sku);
                    item.UpdateCart(product, item.Quantity - quantity);
                }
                else
                {
                    items.Remove(items.First(i => i.Products.Sku == product.Sku));
                }

            }

        }


        public int CountOfItem(string sku)
        {
            var shoppingCart = Get();
            var product = shoppingCart.Items.First(i => i.Products.Sku == sku);
            return product.Quantity - 1;
        }
        public int Count()
        {
            return Get().Items.Count();
        }

        public void DeleteProduct(ShoppingCartItemModel item)
        {
            var items = Get().Items;
            if (HasProduct(item.Products.Sku))
            {
                items.Remove(items.First(i => i.Products.Sku == item.Products.Sku));
            }
        }

        public ShoppingCartModel Get()
        {
            var test = _storageService.ShoppingCart;
            return test;
        }

        public bool HasProduct(string sku)
        {
            var shoppingCart = Get();
            return shoppingCart.Items.Any(i => i.Products.Sku == sku);
        }
    }
}
