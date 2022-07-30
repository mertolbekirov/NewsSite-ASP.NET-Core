using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsSite.Data.Models;

namespace NewsSite.Data
{
    public class NewsSiteDbContext : IdentityDbContext<ApplicationUser>
    {
        public NewsSiteDbContext(DbContextOptions<NewsSiteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; init; }
    }        
}