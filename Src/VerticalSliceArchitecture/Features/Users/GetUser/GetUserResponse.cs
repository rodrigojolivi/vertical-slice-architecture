using VerticalSliceArchitecture.Domain.Entities;

namespace VerticalSliceArchitecture.Features.Users.GetUser
{
    public class GetUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public Guid IdRole { get; set; }
    }

    public static class Converter
    {
        public static ICollection<GetUserResponse> ToResponse(this ICollection<User> users)
        {
            return users.Select(x => new GetUserResponse
            {
                Id = x.Id,
                Email = x.Email,
                IdRole = x.IdRole

            }).ToList();
        }
    }
}
