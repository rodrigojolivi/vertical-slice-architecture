﻿using FluentValidation;

namespace VerticalSliceArchitecture.Features.Users.DeleteUser
{
    public class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("Id is required");
        }
    }
}
