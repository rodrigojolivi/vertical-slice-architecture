using MediatR;
using VerticalSliceArchitecture.Common;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Features.Users.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, bool>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

        public async Task<bool> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            if (Validation.Validate(new UpdateUserValidator(), request)) return false;

            var user = await _userRepository.FindAsync(request.Id);

            if (user == null) return false;

            user.Update(request.Email, request.IdRole);

            var userUpdated = await _userRepository.UpdateAsync(user);

            return userUpdated;
        }
    }
}
