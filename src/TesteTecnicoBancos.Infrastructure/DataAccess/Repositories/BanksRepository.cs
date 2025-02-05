using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories.Banks;

namespace TesteTecnicoBancos.Infrastructure.DataAccess.Repositories;
internal class BanksRepository : IBanksWriteOnlyRepository
{
    private readonly TesteTecnicoBancosDbContext _dbContext;
    public BanksRepository(TesteTecnicoBancosDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Add(Bank bank)
    {
        await _dbContext.AddAsync(bank);
    }

    public async Task<bool> Delete(long id)
    {
        var result = await _dbContext.Banks.FirstOrDefaultAsync(expense => expense.Id == id);
        if (result is null)
        {
            return false;
        }

        _dbContext.Banks.Remove(result);
        return true;
    }
}
