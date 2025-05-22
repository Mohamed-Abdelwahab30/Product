using MediatR;
using Product.Application.Products.Commands;
using Product.Domain.Entities;
using Product.Domain.Interfaces;

namespace Product.Application.Products.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductData>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductData> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var allProducts = await _repository.GetAllAsync();
            int newId = allProducts.Any() ? allProducts.Max(p => p.Id) + 1 : 1;

            var product = new ProductData
            {
                Id = newId,
                Name = request.Name,
                Price = request.Price
            };

            await _repository.AddAsync(product);
            return product;
        }
    }
}
