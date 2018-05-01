using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Blazor;
using System.Threading.Tasks;
using System.Linq;
using AccessControlClient.Repositories.Contracts;

namespace AccessControlClient.Repositories
{
    public class UserRepository : IUserRepository
    {
        //const string BaseUrl = "http://localhost:58009/api";
        const string BaseUrl = "http://hub.midpoint.lt:58009/api";

        private readonly HttpClient _httpClient; 

        public UserRepository(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<int> GetUsersCountAsync()
        {
            var userCount = await _httpClient.GetJsonAsync<int>($"{BaseUrl}/users/count");

            return userCount;
        }

        public async Task<IReadOnlyList<User>> GetUsersAsync(string search = null)
        {
            var userCount = await GetUsersCountAsync();

            var users = await _httpClient.GetJsonAsync<IEnumerable<User>>($"{BaseUrl}/users?skip=0&take={userCount}&search={search}");

            return users.ToList();
        }

        public async Task<SpecificUser> GetUserAsync(int userId)
        {
            var user = await _httpClient.GetJsonAsync<SpecificUser>($"{BaseUrl}/users/{userId}");

            return user;
        }

        public async Task<int> DeleteUserAsync(int userId, string version)
        {
            var httpResponse = await _httpClient.DeleteAsync($"{BaseUrl}/users/{userId}?version={version}");

            return (int)httpResponse.StatusCode;
        }

        public async Task<int> CreateUserAsync(UserModel user)
        {
            var newUser = new CreateUser
            {
                FirstName = user.firstName,
                LastName = user.lastName,
                Email = user.email,
                PhoneNumber = user.phoneNumber,
                UserType = user.userType,
                ActivationDate = user.activationDate
            };

            var newUserId = await _httpClient.PostJsonAsync<int>($"{BaseUrl}/users", newUser);

            return newUserId;
        }

        public async Task UpdateUserAsync(SpecificUser user)
        {
            await _httpClient.PutJsonAsync($"{BaseUrl}/users/{user.id}", user);
        }

        public async Task<IReadOnlyList<UserAccessLevel>> GetUserAccesslevels(int userId)
        {
            var userAccesslevels = await _httpClient.GetJsonAsync<IEnumerable<UserAccessLevel>>($"{BaseUrl}/users/{userId}/accesslevels");

            return userAccesslevels.ToList();
        }

        public async Task<IReadOnlyList<AssignableUserAccessLevel>> GetAssignableUserAccessLevels(int userId)
        {
            var assignableUserAccesslevels = await _httpClient.GetJsonAsync<IEnumerable<AssignableUserAccessLevel>>($"{BaseUrl}/users/{userId}/assignable-accesslevels");

            return assignableUserAccesslevels.ToList();
        }
    }
}
