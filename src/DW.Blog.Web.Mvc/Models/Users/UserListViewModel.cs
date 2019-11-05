using System.Collections.Generic;
using DW.Blog.Roles.Dto;
using DW.Blog.Users.Dto;

namespace DW.Blog.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
