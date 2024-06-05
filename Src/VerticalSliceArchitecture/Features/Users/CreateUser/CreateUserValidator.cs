using FluentValidation;

namespace VerticalSliceArchitecture.Features.Users.CreateUser
{
    public class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty()
                .WithMessage("Email is required");

            RuleFor(x => x.Password).NotEmpty()
                .WithMessage("Password is required");

            RuleFor(x => x.IdRole).NotEmpty()
                .WithMessage("IdRole is required");
        }
    }
}
