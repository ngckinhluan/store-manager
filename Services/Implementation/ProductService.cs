using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository = null;

    public ProductService()
    {
        _productRepository ??= new ProductRepository();
    }
    
    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }

    public Product AddProduct(Product product)
    {
        return _productRepository.AddProduct(product);
    }

    public Product UpdateProduct(int id, Product product)
    {
        return _productRepository.UpdateProduct(id, product);
    }

    public void DeleteProduct(int id)
    {
        _productRepository.DeleteProduct(id);
    }
}