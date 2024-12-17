namespace Ozon.Edu.StockAPI.Configuration.DependencyInjection;

public static class HostBuilderExtension
{
    public static IHostBuilder AddInfrastructure(this IHostBuilder builder, IConfiguration configuration)
    {
        builder.ConfigureServices(service =>
        {
            service.AddControllers();
            service.Configure<JWT>(configuration.GetSection("JWT"));

        });

        return builder;
    }
}
