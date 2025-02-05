using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;

namespace TesteTecnicoBancos.Application.UseCases.Boletos.Register;
public interface IRegisterBoletoUsecase
{
    Task<ResponseRegisteredBoletoJson> Execute(RequestRegisterBoletoJson request);
}
