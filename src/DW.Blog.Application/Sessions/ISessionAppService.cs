using System.Threading.Tasks;
using Abp.Application.Services;
using DW.Blog.Sessions.Dto;

namespace DW.Blog.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
