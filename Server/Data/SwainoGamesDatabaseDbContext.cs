using AspCoreServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AspCoreServer.Data
{
    public class SwainoGamesDatabaseDbContext : DbContext
    {
        public SwainoGamesDatabaseDbContext(DbContextOptions<SwainoGamesDatabaseDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        //List of DB Models - Add your DB models here
        public DbSet<User> User { get; set; }
    }
}
