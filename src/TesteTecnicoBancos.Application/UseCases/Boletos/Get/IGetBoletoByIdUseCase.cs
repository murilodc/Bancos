using TesteTecnicoBancos.Communication.Responses;

namespace TesteTecnicoBancos.Application.UseCases.Boletos.Get;
public interface IGetBoletoByIdUseCase
{
    Task<ResponseBoletoJson> Execute(long id);
}
