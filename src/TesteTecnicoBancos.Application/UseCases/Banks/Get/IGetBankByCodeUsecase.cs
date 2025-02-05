using TesteTecnicoBancos.Communication.Responses;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Get;
public interface IGetBankByCodeUsecase
{
    Task<ResponseBankJson> Execute(int code);
}
