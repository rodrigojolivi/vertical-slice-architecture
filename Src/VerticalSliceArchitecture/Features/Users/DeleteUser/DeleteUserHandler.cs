using MediatR;
using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Features.Users.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, bool>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<bool> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            if (Validation.Validate(new DeleteUserValidator(), request)) return false;

            var user = await _userRepository.FindAsync(request.Id);

            if (user == null) return false;

            var userDeleted = await _userRepository.DeleteAsync(user);

            return userDeleted;
        }
    }
}
