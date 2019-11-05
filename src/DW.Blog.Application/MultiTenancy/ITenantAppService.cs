using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DW.Blog.MultiTenancy.Dto;

namespace DW.Blog.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

