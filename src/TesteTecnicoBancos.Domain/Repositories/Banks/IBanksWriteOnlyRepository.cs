using TesteTecnicoBancos.Domain.Entities;
namespace TesteTecnicoBancos.Domain.Repositories.Banks;
public interface IBanksWriteOnlyRepository
{
    Task Add(Bank bank);
}
