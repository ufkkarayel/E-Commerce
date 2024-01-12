using E_Commerce.Services.Catalog.Dtos.CategoryDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task ResultCategoryDto GetCategoryById(string id);

    }
}
