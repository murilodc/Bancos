using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Infrastructure.DataAccess;
internal class TesteTecnicoBancosDbContext : DbContext
{
    public TesteTecnicoBancosDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Bank> Banks { get; set; }
    public DbSet<Boleto>? Boletos { get; set; }
    
}
