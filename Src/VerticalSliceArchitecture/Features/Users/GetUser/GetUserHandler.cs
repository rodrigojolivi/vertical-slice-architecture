using MediatR;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Features.Users.GetUser
{
    public class GetUserHandler : IRequestHandler<GetUserRequest, ICollection<GetUserResponse>>
    {
        private readonly IUserRepository _userRepository;

        public GetUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<ICollection<GetUserResponse>> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAsync();

            return users.ToResponse();
        }
    }
}
