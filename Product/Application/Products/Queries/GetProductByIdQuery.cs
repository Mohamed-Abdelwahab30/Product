using MediatR;
using Product.Domain.Entities;

namespace Product.Application.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<ProductData>;

}
