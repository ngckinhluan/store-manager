using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDao
    {
        private readonly StoremanagementContext _context = null;

        public CategoryDao()
        {
            if (_context == null)
            {
                _context = new StoremanagementContext();
            }
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category UpdateCategory(int id, Category category)
        {
            var existingCategory = GetCategoryById(id);
            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName;

                _context.Categories.Update(existingCategory);
                _context.SaveChanges();
            }
            return existingCategory;
        }

        public void DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Category not found");
            }
        }


    }
}
