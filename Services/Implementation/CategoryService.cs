using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository = null;
        public CategoryService()
        {
            if (_repository == null)
            {
                _repository = new CategoryRepository();
            }
        }

        public List<Category> GetCategories()
        {
            return _repository.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _repository.GetCategoryById(id);
        }

        public Category AddCategory(Category category)
        {
            return _repository.AddCategory(category);
        }

        public Category UpdateCategory(int id, Category category)
        {
            return _repository.UpdateCategory(id, category);
        }

        public void DeleteCategory(int id)
        {
            _repository.DeleteCategory(id);
        }
    }
}
