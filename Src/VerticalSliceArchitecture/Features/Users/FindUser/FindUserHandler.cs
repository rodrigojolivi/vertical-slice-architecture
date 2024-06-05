using MediatR;
using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Features.Users.FindUser
{
    public class FindUserHandler : IRequestHandler<FindUserRequest, FindUserResponse>
    {
        private readonly IUserRepository _userRepository;

        public FindUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<FindUserResponse> Handle(FindUserRequest request, CancellationToken cancellationToken)
        {
            if (Validation.Validate(new FindUserValidator(), request)) return null;

            var user = await _userRepository.FindAsync(request.Id);

            if (user == null) return null;

            return user.ToResponse();
        }
    }
}
