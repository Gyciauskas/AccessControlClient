using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface IUserTitleRepository
    {
        Task<IReadOnlyList<UserTitle>> GetUserTitlesAsync();
        Task<UserTitle> GetUserTitleAsync(int id);      
    }
}
