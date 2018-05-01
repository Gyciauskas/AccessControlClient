using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface IAccessLevelRepository
    {
        Task<IReadOnlyList<AccessLevel>> GetAccessLevelsAsync(); 
    }
}
