using MediatR;
using Product.Domain.Entities;

namespace Product.Application.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price) : IRequest<ProductData>;

}
