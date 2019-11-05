using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DW.Blog.Authorization.Roles;
using DW.Blog.Authorization.Users;
using DW.Blog.MultiTenancy;

namespace DW.Blog.EntityFrameworkCore
{
    public class BlogDbContext : AbpZeroDbContext<Tenant, Role, User, BlogDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }
    }
}
