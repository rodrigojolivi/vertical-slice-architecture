using FluentValidation;

namespace VerticalSliceArchitecture.Features.Users.UpdateUser
{
    public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("Id is required");

            RuleFor(x => x.Email).NotEmpty()
                .WithMessage("Email is required");

            RuleFor(x => x.IdRole).NotEmpty()
                .WithMessage("IdRole is required");
        }
    }
}
