using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface IDepartmentRepository
    {
        Task<IReadOnlyList<Department>> GetDepartmentsAsync();
        Task<Department> GetDepartmentAsync(int id);    
    }
}
