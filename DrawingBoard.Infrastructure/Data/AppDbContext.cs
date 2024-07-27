using Microsoft.EntityFrameworkCore;
using DrawingBoard.Core.Entities;

namespace DrawingBoard.Infrastructure.Data
{
    
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    public DbSet<Board> Boards { get; set; }
    public DbSet<Drawing> Drawings { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Board>()
            .HasMany(b => b.Drawings)
            .WithOne()
            .HasForeignKey(d => d.BoardId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Board>()
            .HasMany(b => b.Users)
            .WithMany();
    }
}
