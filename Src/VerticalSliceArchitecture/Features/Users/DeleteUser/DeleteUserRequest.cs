using MediatR;

namespace VerticalSliceArchitecture.Features.Users.DeleteUser
{
    public class DeleteUserRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
