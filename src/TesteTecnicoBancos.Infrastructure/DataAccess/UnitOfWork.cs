using TesteTecnicoBancos.Domain.Repositories;

namespace TesteTecnicoBancos.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    public readonly TesteTecnicoBancosDbContext _dbContext;
    public UnitOfWork(TesteTecnicoBancosDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Commit() => await _dbContext.SaveChangesAsync();

}
