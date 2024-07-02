using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
        public Category GetCategoryById(int id);

        public Category AddCategory(Category category);

        public Category UpdateCategory(int id, Category category);

        public void DeleteCategory(int id);

    }
}
