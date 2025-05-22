using MediatR;
using Product.Domain.Entities;

namespace Product.Application.Products.Queries
{
    public record GetAllProductsQuery() : IRequest<List<ProductData>>;

}
