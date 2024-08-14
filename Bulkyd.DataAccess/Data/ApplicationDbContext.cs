using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        //krijimi  i tabeles ne database
        public DbSet<Category>Categories { get; set; }

        // shtimi i te dhenave ne database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {  Id=1, Name="Action", DisplayOrder=1},
                new Category {  Id=2, Name="SciFi", DisplayOrder=2},
                new Category {  Id=3, Name="History", DisplayOrder=3},
                new Category {  Id=4, Name="Adventure", DisplayOrder=4}
                
                );
        }
    }
}
