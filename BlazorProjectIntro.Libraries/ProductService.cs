using BlazorProjectIntro.Libraries.Product;
using BlazorProjectIntro.Libraries.Product.Model;
using BlazorProjectIntro.Libraries.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectIntro.Libraries
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public IList<ProductModel> GetAll()
        {
           return _storageService.products.ToList();
        }

        public ProductModel? GetProduct(string sku)
        {
            return _storageService.products.FirstOrDefault(x => x.Sku == sku);
        }

        public ProductModel? GetProductBySlug(string slug)
        {
            return (_storageService.products.FirstOrDefault(y => y.Slug == slug));
        }
    }
}
