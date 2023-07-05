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
                new Product { Id = 1,ProductName = "Biscolata Pia",Barcode= "",PhotoUrl = "#", Description = "بسکوییت شکلاتی پرتقالی پیا" },
                new Product { Id = 1,ProductName = "Biscolata Mood",Barcode= "",PhotoUrl = "#", Description = "بسکوییت شکلاتی مود برند بیسکولاتا" },
                new Product { Id = 1,ProductName = "OAT",Barcode= "",PhotoUrl = "#", Description = "بیسکوییت گندمی برند " },
                new Product { Id = 1,ProductName = "Oreo",Barcode= "",PhotoUrl = "#", Description = "بیسکوییت کرم دار اورو" },

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
