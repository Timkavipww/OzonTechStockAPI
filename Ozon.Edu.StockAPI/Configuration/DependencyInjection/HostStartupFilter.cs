namespace Ozon.Edu.StockAPI.Configuration.DependencyInjection;

public class HostStartupFilter : IStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseDeveloperExceptionPage();
            app.UseMiddleware<RequestLoggingMiddleware>();
            app.UseRouting();
            app.UseHttpsRedirection();
            app.Map("/version", builder => builder.UseMiddleware<VersionMiddleware>());
            next(app);
        };
    }
}
