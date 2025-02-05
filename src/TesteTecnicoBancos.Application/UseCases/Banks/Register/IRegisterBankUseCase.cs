using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Register;
public interface IRegisterBankUsecase
{
    Task<ResponseRegisteredBankJson> Execute(RequestRegisterBankJson request);
}
