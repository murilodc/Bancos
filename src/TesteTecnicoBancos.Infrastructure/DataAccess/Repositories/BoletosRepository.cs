using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories.Boletos;

namespace TesteTecnicoBancos.Infrastructure.DataAccess.Repositories;
internal class BoletosRepository : IBoletosWriteOnlyRepository, IBoletosReadOnlyRepository
{
    private readonly TesteTecnicoBancosDbContext _dbContext;
    public BoletosRepository(TesteTecnicoBancosDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Add(Boleto boleto)
    {
        await _dbContext.AddAsync(boleto);
    }

    public async Task<Boleto?> GetById(long id)
    {
        return await _dbContext.Boletos.FirstOrDefaultAsync(boleto => boleto.Id == id);
    }
}
