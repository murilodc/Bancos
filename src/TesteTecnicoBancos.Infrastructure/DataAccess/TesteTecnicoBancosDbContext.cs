using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Infrastructure.DataAccess;
internal class TesteTecnicoBancosDbContext : DbContext
{
    public TesteTecnicoBancosDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Bank> Banks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bank>()
            .HasKey(b => new { b.Id, b.Code });

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Boleto>? Boletos { get; set; }
    
}
