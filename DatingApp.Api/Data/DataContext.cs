namespace DatingApp.Api.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        //public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Photo> Photos { get; set; }
    }
}