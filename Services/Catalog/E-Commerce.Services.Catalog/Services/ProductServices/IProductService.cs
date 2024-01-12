using E_Commerce.Services.Catalog.Dtos.ProductDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<ResultProductDto> GetProductById(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
    }
}
