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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDao _categoryDao = null;

        public CategoryRepository()
        {
            _categoryDao ??= new CategoryDao();
        }

        public List<Category> GetCategories()
        {
            return _categoryDao.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDao.GetCategoryById(id);
        }

        public Category AddCategory(Category category)
        {
            return _categoryDao.AddCategory(category);
        }

        public Category UpdateCategory(int id, Category category)
        {
            return _categoryDao.UpdateCategory(id, category);
        }

        public void DeleteCategory(int id)
        {
            _categoryDao.DeleteCategory(id);
        }
    }
}
