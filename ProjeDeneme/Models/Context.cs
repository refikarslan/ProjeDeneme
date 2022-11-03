using Microsoft.EntityFrameworkCore;

namespace ProjeDeneme.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
