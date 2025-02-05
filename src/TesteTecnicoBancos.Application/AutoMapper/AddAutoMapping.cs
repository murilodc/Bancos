using AutoMapper;
using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Entities;

namespace TesteTecnicoBancos.Application.AutoMapper;
public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    private void RequestToEntity()
    {
        CreateMap<RequestRegisterBankJson, Bank>();
        CreateMap<RequestRegisterBoletoJson, Boleto>();
    }
    private void EntityToResponse()
    {
        CreateMap<Bank, ResponseRegisteredBankJson>();
        CreateMap<Bank, ResponseShortBankJson>();
        CreateMap<Bank, ResponseBanksJson>();
        CreateMap<Bank, ResponseBankJson>();
        CreateMap<Boleto, ResponseRegisteredBoletoJson>();
        CreateMap<Boleto, ResponseBoletoJson>();
    }
}