using BusinessObjects.Dto;
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
        public async Task<IActionResult> GetCategories()
        {
           var result = await categoryService.GetCategories();
           if (result == null) return NotFound();
           return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var result = categoryService.GetCategoryById(id);
            if (result == null) return NotFound(); 
            return Ok(result);
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(int id, CategoriesDto categoryDto)
        {
            if (id == null) return BadRequest();
            Category ca = new Category
            {
                CategoryName = categoryDto.CategoryName
            };
            categoryService.UpdateCategory(id, ca);
            return  NoContent();
        }

        [HttpPost("AddNewCategory")]
        public async Task<ActionResult<Category>> AddCategory(CategoriesDto category)
        {
            if (categoryService.GetCategories() == null) return Problem("Entity set 'OrchidContext.orchid' is null");
           var result = categoryService.AddCategory(category);
           return Ok(result);
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
