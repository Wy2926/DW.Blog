using Microsoft.AspNetCore.Antiforgery;
using DW.Blog.Controllers;

namespace DW.Blog.Web.Host.Controllers
{
    public class AntiForgeryController : BlogControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
