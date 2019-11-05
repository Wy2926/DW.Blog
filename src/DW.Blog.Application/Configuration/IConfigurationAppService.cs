using System.Threading.Tasks;
using DW.Blog.Configuration.Dto;

namespace DW.Blog.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
