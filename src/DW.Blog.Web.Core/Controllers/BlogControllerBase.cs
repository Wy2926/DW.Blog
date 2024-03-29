using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DW.Blog.Controllers
{
    public abstract class BlogControllerBase: AbpController
    {
        protected BlogControllerBase()
        {
            LocalizationSourceName = BlogConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
