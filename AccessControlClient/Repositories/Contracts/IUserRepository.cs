using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<User>> GetUsersAsync(string search = null);
        Task<SpecificUser> GetUserAsync(int userId);
        Task<int> GetUsersCountAsync();
        Task<int> CreateUserAsync(UserModel user);    
        Task<int> DeleteUserAsync(int userId, string version);
        Task UpdateUserAsync(SpecificUser user);
        Task<IReadOnlyList<UserAccessLevel>> GetUserAccesslevels(int userId);
        Task<IReadOnlyList<AssignableUserAccessLevel>> GetAssignableUserAccessLevels(int userId);
    }
}
