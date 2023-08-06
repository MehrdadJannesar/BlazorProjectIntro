using BlazorProjectIntro.Libraries.Product.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> products { get; }
        ShoppingCartModel ShoppingCart { get; }

    }
}
