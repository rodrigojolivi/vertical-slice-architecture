namespace VerticalSliceArchitecture.Domain.Entities
{
    public class User(string email, string password, Guid idRole) : Entity
    {
        public string Email { get; private set; } = email;
        public string Password { get; private set; } = password;
        public Guid IdRole { get; private set; } = idRole;

        public void Update(string email, Guid idRole)
        {
            Email = email;
            IdRole = idRole;
        }
    }
}
