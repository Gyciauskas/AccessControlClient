using AccessControlClient.Repositories.Contracts;
using Microsoft.AspNetCore.Blazor.Components;

namespace AccessControlClient
{
    public class ComponentBases : BlazorComponent
    {
        [Inject]
        protected IDepartmentRepository DepartmentRepository { get; set; }

        [Inject]
        protected IUserTitleRepository UserTitleRepository { get; set; }

        [Inject]
        protected ICompanyRepository CompanyRepository { get; set; }

        [Inject]
        protected IAccessLevelRepository AccessLevelRepository { get; set; }        

        [Inject]
        protected IUserRepository UserRepository { get; set; }      
    }
}
