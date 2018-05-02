using AccessControlClient.Repositories.Contracts;
using AccessControlClient.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace AccessControlClient.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        const string BaseUrl = "http://localhost:58009/api";
        //const string BaseUrl = "http://hub.midpoint.lt:58009/api";

        private readonly HttpClient _httpClient;

        public CompanyRepository(HttpClient client) 
        {
            _httpClient = client;
        }

        public async Task<IReadOnlyList<Company>> GetCompaniesAsync()
        {
            var companies = await _httpClient.GetJsonAsync<IEnumerable<Company>>($"{BaseUrl}/locations/1/companies");

            return companies.OrderBy(u => u.name).ToList();
        }

        public async Task<Company> GetCompanyAsync(int id)
        {
            var company = await _httpClient.GetJsonAsync<Company>($"{BaseUrl}/locations/1/companies/{id}");

            return company;
        }
    }
}
