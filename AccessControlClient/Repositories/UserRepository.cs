using AccessControlClient.Repositories.Contracts;
using AccessControlClient.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AccessControlClient.Repositories
{
    public class UserRepository //: IUserRepository
    {
        private readonly HttpClient _httpClient; 

        public UserRepository(HttpClient client)
        {
            _httpClient = client;
        }

        //public async Task<IReadOnlyList<User>> GetAllUsersAsync()
        //{
        //    var response = await _httpClient."http://localhost:58009/api/users?skip=0&take=10000");

        //    var userList = response.Content;


        //}
    }
}
