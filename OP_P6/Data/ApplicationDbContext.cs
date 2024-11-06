using Microsoft.EntityFrameworkCore;
using OP_P6.Data.Entities;

namespace OP_P6.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    DbSet<Ticket> Tickets { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<Entities.Version> Versions { get; set; }
    DbSet<Entities.OperatingSystem> OperatingSystems { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Product>()
            .HasMany(p => p.Versions)
            .WithOne(v => v.Product)
            .HasForeignKey(v => v.ProductId);

        modelBuilder
            .Entity<Entities.Version>()
            .HasMany(v => v.OperatingSystems)
            .WithMany(o => o.Versions);


        modelBuilder
            .Entity<Ticket>()
            .HasOne(t => t.Version)
            .WithMany(v => v.Tickets)
            .HasForeignKey(t => t.VersionId);


        modelBuilder
            .Entity<Ticket>()
            .HasOne(t => t.OperatingSystem)
            .WithMany(o => o.Tickets)
            .HasForeignKey(t => t.OperatingSystemId);
    }

}
