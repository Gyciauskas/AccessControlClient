using AccessControlClient.Repositories.Contracts;
using AccessControlClient.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace AccessControlClient.Repositories
{
    public class AccessLevelRepository : IAccessLevelRepository
    {
        const string BaseUrl = "http://localhost:58009/api";
        //const string BaseUrl = "http://hub.midpoint.lt:58009/api";

        private readonly HttpClient _httpClient;

        public AccessLevelRepository(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<IReadOnlyList<AccessLevel>> GetAccessLevelsAsync()
        {
            var accessLevels = await _httpClient.GetJsonAsync<IEnumerable<AccessLevel>>($"{BaseUrl}/locations/1/accesslevels");

            return accessLevels.OrderBy(u => u.name).ToList();
        }
    }
}
