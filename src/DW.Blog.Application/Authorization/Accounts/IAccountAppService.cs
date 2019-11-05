using System.Threading.Tasks;
using Abp.Application.Services;
using DW.Blog.Authorization.Accounts.Dto;

namespace DW.Blog.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
