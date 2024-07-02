using BusinessObjects.Entities;

namespace Services.Interface;

public interface IProductService
{
    public List<Product> GetProducts(); 
    public Product GetProductById(int id);
    public Product AddProduct(Product product);
    public Product UpdateProduct(int id, Product product);
    public void DeleteProduct(int id);
}