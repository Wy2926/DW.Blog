using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DW.Blog.Configuration.Dto;

namespace DW.Blog.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BlogAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
