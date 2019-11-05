using System.Collections.Generic;
using DW.Blog.Roles.Dto;

namespace DW.Blog.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}