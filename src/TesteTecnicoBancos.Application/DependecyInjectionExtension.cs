using TesteTecnicoBancos.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TesteTecnicoBancos.Application.UseCases.Banks.Register;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Application.UseCases.Boletos.Register;
using TesteTecnicoBancos.Application.UseCases.Boletos.Get;

namespace TesteTecnicoBancos.Application;
public static class DependecyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }
    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterBankUsecase, RegisterBankUseCase>();
        services.AddScoped<IGetAllBanksUseCase, GetAllBanksUsecase>();
        services.AddScoped<IGetBankByCodeUsecase, GetBankByCodeUseCase>();
        services.AddScoped<IRegisterBoletoUsecase, RegisterBoletoUseCase>();
        services.AddScoped<IGetBoletoByIdUseCase, GetBoletoByIdUsecase>();
    }
}
