using Microsoft.EntityFrameworkCore;
using DiaryAPP.Models;

namespace DiaryAPP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet to represent the DiaryEntries table in the database
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        // Override OnModelCreating to configure initial data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding initial data into the DiaryEntries table
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Go on Hiking",
                    Content = "Hiking",
                    Created = new DateTime(2024, 04, 29, 0, 0, 0, DateTimeKind.Utc)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Go on Shopping",
                    Content = "Shop",
                    Created = new DateTime(2024, 04, 29, 0, 0, 0, DateTimeKind.Utc)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Go on Skiing",
                    Content = "Ski",
                    Created = new DateTime(2024, 04, 29, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}
