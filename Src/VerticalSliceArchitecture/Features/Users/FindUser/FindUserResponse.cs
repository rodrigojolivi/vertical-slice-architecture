using VerticalSliceArchitecture.Domain.Entities;

namespace VerticalSliceArchitecture.Features.Users.FindUser
{
    public class FindUserResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid IdRole { get; set; }
    }

    public static class Converter
    {
        public static FindUserResponse ToResponse(this User user)
        {
            return new FindUserResponse
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
                IdRole = user.IdRole
            };
        }
    }
}
