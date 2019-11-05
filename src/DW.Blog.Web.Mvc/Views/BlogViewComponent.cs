using Abp.AspNetCore.Mvc.ViewComponents;

namespace DW.Blog.Web.Views
{
    public abstract class BlogViewComponent : AbpViewComponent
    {
        protected BlogViewComponent()
        {
            LocalizationSourceName = BlogConsts.LocalizationSourceName;
        }
    }
}
