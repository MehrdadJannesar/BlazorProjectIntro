using BlazorProjectIntro.Libraries.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.ShoppingCart
{
    public interface IShoppingCartService
    {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        void DeleteProduct(ShoppingCartItemModel item);
        int Count();
        bool HasProduct(string sku);
        void RemoveProduct(ProductModel product, int quantity);
        int CountOfItem(string sku);
    }
}
