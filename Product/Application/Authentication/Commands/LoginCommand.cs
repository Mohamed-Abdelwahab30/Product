using MediatR;
using Product.Application.Common;

namespace Product.Application.Authentication.Commands
{
    public record LoginCommand(string Email,string Password) : IRequest<IAppResult>;
}
