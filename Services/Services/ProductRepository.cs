using Models;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1,ProductName = "Biscolata Pia",Barcode= "",
                    PhotoUrl = "https://shocoshop.com/wp-content/uploads/2020/11/Biscolata-Pia-Cake-with-Orange-100-G.jpg", Description = "بسکوییت شکلاتی پرتقالی پیا" },
                new Product { Id = 1,ProductName = "Biscolata Mood",Barcode= "",
                    PhotoUrl = "https://abnabatshop.com/wp-content/uploads/2020/08/watermark-5.jpg", Description = "بسکوییت شکلاتی مود برند بیسکولاتا" },
                new Product { Id = 1,ProductName = "Nutri",Barcode= "",
                    PhotoUrl = "https://www.ishopindian.com/images/D/5grain_nc.jpg", Description = "بیسکوییت گندمی برند " },
                new Product { Id = 1,ProductName = "Oreo",Barcode= "",
                    PhotoUrl = "https://ecom-su-static-prod.wtrecom.com/images/products/4/LN_448126_BP_4.jpg", Description = "بیسکوییت کرم دار اورو" },

            };
        }
        public IEnumerable<Product> GetAllProduct()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return product;
            }
            else
                return null;
        }
        public bool Edit(Product product)
        {
            var item = _products.FirstOrDefault(x => x.Id == product.Id);
            if (item != null)
            {
                item.ProductName = product.ProductName;
                item.Description = product.Description;
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var item = _products.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _products.Remove(item);
                return true;
            }
            return false;

        }

    }
}
