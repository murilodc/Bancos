using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Domain.Repositories.Boletos;
public interface IBoletosReadOnlyRepository
{
    Task<Boleto?> GetById(long id);
}
