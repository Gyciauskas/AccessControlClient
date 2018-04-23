using AccessControlClient.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<User>> GetAllUsersAsync();   
    }
}
