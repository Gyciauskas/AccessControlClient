using AccessControlClient.Repositories;
using AccessControlClient.Repositories.Contracts;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AccessControlClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.Add(ServiceDescriptor.Singleton<IUserRepository, UserRepository>());
                configure.Add(ServiceDescriptor.Singleton<IDepartmentRepository, DepartmentRepository>());
                configure.Add(ServiceDescriptor.Singleton<ICompanyRepository, CompanyRepository>());
                configure.Add(ServiceDescriptor.Singleton<IUserTitleRepository, UserTitleRepository>());
                configure.Add(ServiceDescriptor.Singleton<IAccessLevelRepository, AccessLevelRepository>());
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
