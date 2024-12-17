using Grpc.Core;
using Ozon.Edu.StockAPI.Grpc;

namespace Ozon.Edu.StockAPI.GrpcServices;

public class StockAPIGrpcService : StockAPIGrpc.StockAPIGrpcBase
{
    private readonly IStockSerice _stockService;

    public StockAPIGrpcService(IStockSerice stockSerice)
    {
        _stockService = stockSerice;
    }
    public override async Task<GetAllStockItemsResponse> GetAllStockItems(
        GetAllStockItemsRequest request,
        ServerCallContext context)
    {

        //return base.GetAllStockItems(request, context);\
        var stockItems = await _stockService.GetAll(context.CancellationToken);

        return new GetAllStockItemsResponse
        {
            Stocks = {stockItems.Select(x => new GetAllStockItemsResponseUnit
            {
                ItemId = x.ItemId,
                ItemName = x.ItemName,
                Quantity = x.Quanity
            })}
        };
    }
}
