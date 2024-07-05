using AutoMapper;
using BusinessObjects.Dto;
using BusinessObjects.Entities;

namespace StoreManagement.Extensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoriesDto>();
        }

    }
}
