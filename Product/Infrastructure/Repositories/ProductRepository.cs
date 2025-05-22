using Product.Domain.Entities;
using Product.Domain.Interfaces;

namespace Product.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<ProductData> _products = new()
    {
        new ProductData { Id = 1, Name = "Laptop", Price = 1500 },
        new ProductData { Id = 2, Name = "Phone", Price = 800 }
    };

        public Task<List<ProductData>> GetAllAsync() => Task.FromResult(_products);
        public Task<ProductData> GetByIdAsync(int id) => Task.FromResult(_products.FirstOrDefault(p => p.Id == id));
        public Task AddAsync(ProductData product)
        {
            _products.Add(product);
            return Task.CompletedTask;
        }
    }
}
