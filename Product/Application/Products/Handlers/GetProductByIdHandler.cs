using MediatR;
using Product.Application.Products.Queries;
using Product.Domain.Entities;
using Product.Domain.Interfaces;

namespace Product.Application.Products.Handlers
{

    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductData>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductData> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            return product;
        }
    }
}
