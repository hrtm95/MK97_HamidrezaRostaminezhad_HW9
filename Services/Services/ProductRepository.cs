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
                new Product { Id = 1,ProductName = "flashlight",Barcode= "123456",Price = 10000,
                    PhotoUrl = "1.jpg",
                    Description = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent.\r\n\r\nMost flashlights are powered with batteries, although some of them can be charged in the sun and use the stored solar energy for power. All flashlights are portable, basically small lamps that fit easily in your hand, your pocket, or your backpack. In Britain, a flashlight is often called a torch. The earliest versions of flashlights were invented around 1899.",
                    ShortDescription = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent." },
                new Product { Id = 2,ProductName = "Smart watch",Barcode= "123456789",
                    PhotoUrl = "2.jpg", Description = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent.\r\n\r\nMost flashlights are powered with batteries, although some of them can be charged in the sun and use the stored solar energy for power. All flashlights are portable, basically small lamps that fit easily in your hand, your pocket, or your backpack. In Britain, a flashlight is often called a torch. The earliest versions of flashlights were invented around 1899.",
                    ShortDescription = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent." 
                    , Price = 10000},
                new Product { Id = 3,ProductName = "Camera",Barcode= "12345678",
                    PhotoUrl = "3.jpg",Description = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent.\r\n\r\nMost flashlights are powered with batteries, although some of them can be charged in the sun and use the stored solar energy for power. All flashlights are portable, basically small lamps that fit easily in your hand, your pocket, or your backpack. In Britain, a flashlight is often called a torch. The earliest versions of flashlights were invented around 1899.",
                    ShortDescription = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent." 
                    , Price =20000},
                new Product { Id = 4,ProductName = "Oreo",Barcode= "123456",
                    PhotoUrl = "4.jpg",
                    Description = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent.\r\n\r\nMost flashlights are powered with batteries, although some of them can be charged in the sun and use the stored solar energy for power. All flashlights are portable, basically small lamps that fit easily in your hand, your pocket, or your backpack. In Britain, a flashlight is often called a torch. The earliest versions of flashlights were invented around 1899.",
                    ShortDescription = "A flashlight is a light that's small enough to hold in your hand and carry around. When you're camping, it's useful to bring a flashlight so you can find your sleeping bag in the dark tent."
                    , Price = 50000 },

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
                item.Price = product.Price;
                item.ShortDescription = product.ShortDescription;
                item.Barcode = product.Barcode;
                item.PhotoUrl = product.PhotoUrl;
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
