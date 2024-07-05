using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessObjects.Dto;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository = null;
        private readonly IMapper _mapper = null;
        public CategoryService(IMapper mapper)
        {
            if (_repository == null)
            {
                _repository = new CategoryRepository();
            }
            _mapper = mapper;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _repository.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _repository.GetCategoryById(id);
        }

        public Category AddCategory(CategoriesDto categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
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
