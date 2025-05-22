using Product.Domain.Entities;

namespace Product.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductData>> GetAllAsync();
        Task<ProductData> GetByIdAsync(int id);
        Task AddAsync(ProductData product);
    }
}
