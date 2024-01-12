using E_Commerce.Services.Catalog.Dtos.CategoryDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        void UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        void DeleteCategoryAsync(string id);
        ResultCategoryDto GetCategoryById(string id);

    }
}
