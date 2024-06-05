using MediatR;
using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Domain.Entities;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Features.Users.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, bool>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<bool> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            if (Validation.Validate(new CreateUserValidator(), request)) return false;

            var user = new User(request.Password, request.Password, request.IdRole);

            var userCreated = await _userRepository.CreateAsync(user);

            return userCreated;
        }
    }
}
