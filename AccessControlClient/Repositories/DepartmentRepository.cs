using AccessControlClient.Repositories.Contracts;
using AccessControlClient.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using System.Linq;

namespace AccessControlClient.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //const string BaseUrl = "http://localhost:58009/api";
        const string BaseUrl = "http://hub.midpoint.lt:58009/api";

        private readonly HttpClient _httpClient;

        public DepartmentRepository(HttpClient client)  
        {
            _httpClient = client;
        }

        public async Task<IReadOnlyList<Department>> GetDepartmentsAsync()
        {
            var departments = await _httpClient.GetJsonAsync<IEnumerable<Department>>($"{BaseUrl}/locations/1/departments");

            return departments.OrderBy(u => u.name).ToList();
        }

        public async Task<Department> GetDepartmentAsync(int id)   
        {
            var department = await _httpClient.GetJsonAsync<Department>($"{BaseUrl}/locations/1/departments/{id}");

            return department;
        }
    }
}
