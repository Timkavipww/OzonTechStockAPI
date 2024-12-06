namespace Ozon.Edu.StockAPI.DependencyInjections;

public static class Services
{
    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen();
    }
}
public static class ServicesConfigure
{
    public static IApplicationBuilder AddConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
    {
      
        return app;
    }
}
public static class SwaggerInjection
{
    public static void AddSwaggerConfiguration(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
