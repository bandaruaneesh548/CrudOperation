using Codepulse.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Codepulse.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Blogpost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
