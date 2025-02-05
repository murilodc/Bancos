using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Domain.Repositories.Banks;
public interface IBanksReadOnlyRepository
{
    Task<List<Bank>> GetAll();
    Task<Bank?> GetByCode(int code);
    Task<Bank?> GetByBankId(long bankId);
}
