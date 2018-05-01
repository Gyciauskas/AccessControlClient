using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface ICompanyRepository
    {
        Task<IReadOnlyList<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyAsync(int id);        
    }
}
