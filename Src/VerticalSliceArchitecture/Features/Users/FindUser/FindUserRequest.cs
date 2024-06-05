using MediatR;

namespace VerticalSliceArchitecture.Features.Users.FindUser
{
    public class FindUserRequest : IRequest<FindUserResponse>
    {
        public Guid Id { get; set; }
    }
}
