using Abp.Authorization;
using DW.Blog.Authorization.Roles;
using DW.Blog.Authorization.Users;

namespace DW.Blog.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
