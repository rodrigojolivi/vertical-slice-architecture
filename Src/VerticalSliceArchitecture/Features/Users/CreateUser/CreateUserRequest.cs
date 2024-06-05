using MediatR;

namespace VerticalSliceArchitecture.Features.Users.CreateUser
{
    public class CreateUserRequest : IRequest<bool>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid IdRole { get; set; }
    }
}
