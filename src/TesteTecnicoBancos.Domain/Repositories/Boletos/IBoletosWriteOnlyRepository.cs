using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Domain.Repositories.Boletos;
public interface IBoletosWriteOnlyRepository
{
    Task Add(Boleto boleto);
}
