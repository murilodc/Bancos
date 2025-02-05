using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TesteTecnicoBancos.Infrastructure.DataAccess;

namespace TesteTecnicoBancos.Infrastructure.Migrations;
public static class DataBaseMigration
{
    public async static Task MigrateDatabase(IServiceProvider serviceProvider)
    {
        var dbContext = serviceProvider.GetRequiredService<TesteTecnicoBancosDbContext>();

        await dbContext.Database.MigrateAsync();
    }
}
