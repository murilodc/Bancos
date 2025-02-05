using TesteTecnicoBancos.Communication.Responses;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Get;
public interface IGetAllBanksUseCase
{
    Task<ResponseBanksJson> Execute();
}
