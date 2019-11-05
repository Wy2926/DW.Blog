using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DW.Blog.Roles.Dto;
using DW.Blog.Users.Dto;

namespace DW.Blog.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
