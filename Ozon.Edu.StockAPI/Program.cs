using Ozon.Edu.StockAPI.Configuration.DependencyInjection;
using Ozon.Edu.StockAPI.GrpcServices;

var builder = WebApplication.CreateBuilder();

builder.Services.AddServicesDI();
builder.Services.AddGrpc();
builder.Host.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapControllers();
app.MapGrpcService<StockAPIGrpcService>();
app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();
