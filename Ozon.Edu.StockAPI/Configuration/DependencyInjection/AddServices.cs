namespace Ozon.Edu.StockAPI.Configuration.DependencyInjection;

public static class AddServices
{
    public static IServiceCollection AddServicesDI(this IServiceCollection services)
    {
        services.AddSwaggerGen(
        options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo()
            {
                Title = "OzonEdu.StockApi",
                Version = "v1",
                Description = "use for fun",
                License = new OpenApiLicense() { Name = "xd" }
            }
            );
            options.CustomSchemaIds(s => s.FullName);
            var xmlFileName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
            var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);

            options.IncludeXmlComments(xmlFilePath);
            options.OperationFilter<HeaderOperationFilter>();
        });

        services.AddTransient<IAuthService, AuthService>();
        services.AddScoped<ILogger, Logger<Program>>();
        services.AddSingleton<IStockSerice, StockService>();
        services.AddSingleton<IStartupFilter, HostStartupFilter>();

        return services;
    }
}
