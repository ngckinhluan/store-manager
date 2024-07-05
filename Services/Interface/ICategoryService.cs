using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Dto;

namespace Services.Interface
{
    public interface ICategoryService
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategoryById(int id);
        public Category AddCategory(CategoriesDto categories);
        public Category UpdateCategory(int id, Category category);
        public void DeleteCategory(int id);
    }
}
