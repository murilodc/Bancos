using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TesteTecnicoBancos.Infrastructure.DataAccess;
using TesteTecnicoBancos.Domain.Repositories;
using TesteTecnicoBancos.Domain.Repositories.Banks;
using TesteTecnicoBancos.Infrastructure.DataAccess.Repositories;
using TesteTecnicoBancos.Domain.Repositories.Boletos;

namespace TesteTecnicoBancos.Infrastructure;
public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services,configuration);
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IBanksWriteOnlyRepository, BanksRepository>();
        services.AddScoped<IBanksReadOnlyRepository, BanksRepository>();
        services.AddScoped<IBoletosWriteOnlyRepository, BoletosRepository>();
        services.AddScoped<IBoletosReadOnlyRepository, BoletosRepository>();
    }
    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgresConnection")
            ?? throw new InvalidOperationException("A connection string 'PostgresConnection' não foi encontrada.");

        var version = new Version(8, 0, 35);
        

        services.AddDbContext<TesteTecnicoBancosDbContext>(options => options.UseNpgsql(connectionString));
    }
}
