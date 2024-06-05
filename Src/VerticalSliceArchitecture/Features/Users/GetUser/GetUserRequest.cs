using MediatR;

namespace VerticalSliceArchitecture.Features.Users.GetUser
{
    public class GetUserRequest : IRequest<ICollection<GetUserResponse>>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
