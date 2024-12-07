using Ozon.Edu.StockAPI.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices(builder.Configuration);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.AddSwaggerConfiguration();
}
app.MapGet("/api", () => Results.Redirect("/swagger"));
app.MapGet("/web", () => Results.Redirect("/swagger"));

app.Run();

//MERGE
//MERGING IS WORKING?
//TEST BRANCH
//NO ./ADDasd
