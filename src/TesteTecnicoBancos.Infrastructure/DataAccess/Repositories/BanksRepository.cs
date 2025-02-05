using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories.Banks;

namespace TesteTecnicoBancos.Infrastructure.DataAccess.Repositories;
internal class BanksRepository : IBanksWriteOnlyRepository, IBanksReadOnlyRepository
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

    public async Task<List<Bank>> GetAll()
    {
        return await _dbContext.Banks.AsNoTracking().ToListAsync();
    }

    public async Task<Bank?> GetByBankId(long bankId)
    {
        return await _dbContext.Banks.FirstOrDefaultAsync(bank => bank.Id == bankId);
    }

    public async Task<Bank?> GetByCode(int code)
    {
        return await _dbContext.Banks.FirstOrDefaultAsync(bank =>  bank.Code == code);
    }
}
