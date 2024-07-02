using BusinessObjects.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace StoreManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
   private readonly IProductService _productService = null;

   public ProductsController()
   {
      _productService ??= new ProductService();
   }
   
   [HttpGet]
   public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
   {
      if (_productService.GetProducts() != null) return _productService.GetProducts().ToList();
      return NotFound();
   }
   
   [HttpGet("{id}")]
   public async Task<ActionResult<Product>> GetProduct(int id)
   {
      if (_productService.GetProducts() == null) NotFound();
      var product = _productService.GetProductById(id);
      if (product == null) return NotFound(); 
      return product;
   }
   
   [HttpPut("UpdateProduct")]
   public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
   {
      if (id != product.ProductId) return BadRequest();
      _productService.UpdateProduct(id, product);
      return NoContent();
   }

   [HttpPost("AddNewProduct")]
   public async Task<ActionResult<Product>> AddProduct(Product product)
   {
      if (_productService.GetProducts() == null) return Problem("Entity set 'OrchidContext.orchid' is null");
      _productService.AddProduct(product);
      return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
   }

   [HttpDelete("DeleteProduct")]
   public async Task<IActionResult> DeleteProduct(int id)
   {
      if (_productService.GetProducts() == null) return NotFound();
      _productService.DeleteProduct(id);
      return NoContent();
   }
}