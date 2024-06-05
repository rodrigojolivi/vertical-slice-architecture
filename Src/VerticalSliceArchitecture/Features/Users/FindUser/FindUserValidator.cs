using FluentValidation;

namespace VerticalSliceArchitecture.Features.Users.FindUser
{
    public class FindUserValidator : AbstractValidator<FindUserRequest>
    {
        public FindUserValidator()
        {
            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("Id is required");
        }
    }
}
