using AutoMapper;
using E_Commerce.Services.Catalog.Dtos.CategoryDtos;
using E_Commerce.Services.Catalog.Dtos.ProductDtos;
using E_Commerce.Services.Catalog.Models;

namespace E_Commerce.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category,ResultCategoryDto>();
            CreateMap<ResultCategoryDto, Category>();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();

            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
        }
    }
}
