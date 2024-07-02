using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;

namespace DAO
{
    public class ProductDao
    {
        private readonly StoremanagementContext _context = null;

        public ProductDao()
        {
            _context ??= new StoremanagementContext();
        }
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var existingProduct = GetProductById(id);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.UnitPrice = product.UnitPrice;
                existingProduct.UnitsInStock = product.UnitsInStock;
                existingProduct.Weight = product.Weight;
                existingProduct.OrderDetails = product.OrderDetails;
                _context.Products.Update(existingProduct);
                _context.SaveChanges();
                return existingProduct;
            }
            else throw new KeyNotFoundException("Product not found");
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            else throw new KeyNotFoundException("Product not found");
        }


    }
}
