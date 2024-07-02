using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDao _productDao = null;

        public ProductRepository()
        {
            _productDao ??= new ProductDao();
        }
        public List<Product> GetProducts()
        {
            return _productDao.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _productDao.GetProductById(id);
        }

        public Product AddProduct(Product product)
        {
            return _productDao.AddProduct(product);
        }

        public Product UpdateProduct(int id, Product product)
        {
            return _productDao.UpdateProduct(id, product);
        }

        public void DeleteProduct(int id)
        {
            _productDao.DeleteProduct(id);
        }
    }
}
