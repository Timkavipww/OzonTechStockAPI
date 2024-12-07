var builder = WebApplication.CreateBuilder();



builder.Logging.AddConsole();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapGet("/", () => "Hello World");
app.UseHttpsRedirection();
app.Run();
