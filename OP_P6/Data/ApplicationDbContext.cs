using Microsoft.EntityFrameworkCore;
using OP_P6.Data.Entities;

namespace OP_P6.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Entities.Version> Versions { get; set; }
    public DbSet<Entities.OperatingSystem> OperatingSystems { get; set; }
    public DbSet<ProductVersionOperatingSystem> ProductVersionOperatingSystems { get; set; }

    override protected void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}
