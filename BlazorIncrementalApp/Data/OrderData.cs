using Microsoft.EntityFrameworkCore;

namespace BlazorIncrementalApp.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        public DbSet<Points> Points { get; set; }
        public DbSet<Buttons> Buttons { get; set; }
        public DbSet<MoonPoints> MoonPoints { get; set; }
        public DbSet<VenusPoints> VenusPoints { get; set; }
        public DbSet<MindoorOres> MindoorOres { get; set; }

    }
}
