using BusinessObjects.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implementation;
using Services.Interface;

namespace StoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService = null;

        public CategoriesController()
        {
            categoryService ??= new CategoryService();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            if (categoryService.GetCategories() != null) return categoryService.GetCategories().ToList();
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            if (categoryService.GetCategories() == null) NotFound();
            var category = categoryService.GetCategoryById(id);
            if (category == null) return NotFound(); 
            return category;
        }

        [HttpPut("UpdateCategory")]
        public async Task<ActionResult<Category>> UpdateCategory(int id, Category category)
        {
            if (id != category.CategoryId) return BadRequest();
            categoryService.UpdateCategory(id, category);
            return NoContent();
        }

        [HttpPost("AddNewCategory")]
        public async Task<ActionResult<Category>> AddCategory(Category category)
        {
            if (categoryService.GetCategories() == null) return Problem("Entity set 'OrchidContext.orchid' is null");
            categoryService.AddCategory(category);
            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (categoryService.GetCategories() == null) return NotFound();
            categoryService.DeleteCategory(id);
            return NoContent();
        }
    }
}
