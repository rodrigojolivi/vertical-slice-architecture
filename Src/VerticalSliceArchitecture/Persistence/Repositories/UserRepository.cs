using VerticalSliceArchitecture.Domain.Entities;
using VerticalSliceArchitecture.Domain.Repositories;

namespace VerticalSliceArchitecture.Persistence.Repositories
{
    // Fake repository

    public class UserRepository : IUserRepository
    {
        public async Task<ICollection<User>> GetAsync()
        {
            return
            [
                new User("dorothyr@gmail.com", "Administrator", Guid.NewGuid()),
                new User("lisaflint@gmail.com", "Manager", Guid.NewGuid()),
                new User("wallacelpeterson@gmail.com", "Operator", Guid.NewGuid())
            ];
        }

        public async Task<User> FindAsync(Guid id)
        {
            return new User("dorothyr@gmail.com", "Administrator", id);
        }

        public async Task<bool> CreateAsync(User user)
        {
            return true;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            return true;
        }

        public async Task<bool> DeleteAsync(User user)
        {
            return true;
        }
    }
}
