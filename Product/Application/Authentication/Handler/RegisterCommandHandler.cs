using MediatR;
using Microsoft.AspNetCore.Identity;
using Product.Application.Authentication.Commands;
using Product.Application.Authentication.Dtos;
using Product.Application.Common;
using Product.Domain.Entities;

namespace Product.Application.Authentication.Handler
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, IAppResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IAppResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser { UserName = request.Email, Email = request.Email };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description).ToArray();
                return AppResult.Failure(errors); 
            }

            return AppResult.Success("Registered successfully");
        }
    }
}
