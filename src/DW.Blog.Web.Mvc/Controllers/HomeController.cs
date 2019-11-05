using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using DW.Blog.Controllers;

namespace DW.Blog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
