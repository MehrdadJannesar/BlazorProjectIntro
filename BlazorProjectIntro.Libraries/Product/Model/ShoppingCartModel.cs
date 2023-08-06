using BlazorProjectIntro.Libraries.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.Product.Model
{
    public class ShoppingCartModel
    {
        public IList<ShoppingCartItemModel> Items { get; set; }

        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }
    }
}
