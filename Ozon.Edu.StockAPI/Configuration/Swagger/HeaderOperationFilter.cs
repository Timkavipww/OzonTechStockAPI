namespace Ozon.Edu.StockAPI.Configuration.Swagger;

public class HeaderOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (context.ApiDescription.RelativePath == "v1/api/stocks")
        {
            operation.Parameters ??= new List<OpenApiParameter>();
            operation.Parameters.Add(new OpenApiParameter
            {
                In = ParameterLocation.Header,
                Name = "our-header",
                Required = false,
                Description = "desctiption",
                Schema = new OpenApiSchema { Type = "string" }
            });
        }
    }
}
