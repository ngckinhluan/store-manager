using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IProductRepository
    {
        public List<Product> GetProducts(); 
        public Product GetProductById(int id);
        public Product AddProduct(Product product);
        public Product UpdateProduct(int id, Product product);
        public void DeleteProduct(int id);
    }
}
