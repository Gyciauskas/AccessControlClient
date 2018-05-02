using AccessControlClient.Repositories.Contracts;
using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace AccessControlClient.Repositories
{
    public class UserTitleRepository : IUserTitleRepository
    {
        const string BaseUrl = "http://localhost:58009/api";
        //const string BaseUrl = "http://hub.midpoint.lt:58009/api";

        private readonly HttpClient _httpClient;

        public UserTitleRepository(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<UserTitle> GetUserTitleAsync(int id)
        {
            var userTitle = await _httpClient.GetJsonAsync<UserTitle>($"{BaseUrl}/locations/1/usertitles/{id}");

            return userTitle;   
        }

        public async Task<IReadOnlyList<UserTitle>> GetUserTitlesAsync()
        {
            var userTitles = await _httpClient.GetJsonAsync<IEnumerable<UserTitle>>($"{BaseUrl}/locations/1/usertitles");

            return userTitles.OrderBy(u => u.name).ToList();
        }
    }
}
    