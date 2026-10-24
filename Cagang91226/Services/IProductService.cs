using Cagang91226.MODELS.Dto;
namespace Cagang91226.Services
{
        public interface IProductService
        {
            Task<IEnumerable<ProductDto>> GetAllAsync();
            Task<ProductDto?> GetByIdAsync(int id);
            Task<ProductDto> CreateAsync(CreateProductDto input);
        }
    
}