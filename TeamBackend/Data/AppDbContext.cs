using System.Data.Entity;
using TeamBackend.Models;

namespace TeamBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<UserData> Users { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserData>().ToTable("Users");
        }
    }
}
