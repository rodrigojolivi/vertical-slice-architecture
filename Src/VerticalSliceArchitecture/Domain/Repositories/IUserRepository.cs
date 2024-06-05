using VerticalSliceArchitecture.Domain.Entities;

namespace VerticalSliceArchitecture.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetAsync();
        Task<User> FindAsync(Guid id);
        Task<bool> CreateAsync(User user);
        Task<bool> UpdateAsync(User user);
        Task<bool> DeleteAsync(User user);
    }
}
