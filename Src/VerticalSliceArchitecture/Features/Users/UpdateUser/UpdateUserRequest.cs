using MediatR;

namespace VerticalSliceArchitecture.Features.Users.UpdateUser
{
    public class UpdateUserRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid IdRole { get; set; }
    }
}
