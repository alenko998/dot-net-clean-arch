using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities; // 👈 dodaj ovaj using za Blog entitet

namespace Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // ✅ DbSet za Blog
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ako želiš, kasnije dodaj konfiguraciju/seed za IdentityRole
            // builder.Entity<IdentityRole>().HasData(...)
        }
    }
}
