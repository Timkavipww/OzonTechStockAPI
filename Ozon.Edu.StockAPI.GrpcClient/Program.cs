
using Grpc.Net.Client;
using Ozon.Edu.StockAPI.Grpc;
using System.Data;

using var channel = GrpcChannel.ForAddress("https://localhost:7187");
var client = new StockAPIGrpc.StockAPIGrpcClient(channel);

var response = await client.GetAllStockItemsAsync(new GetAllStockItemsRequest(), cancellationToken: CancellationToken.None);
foreach(var item in response.Stocks)
{
    Console.WriteLine($"item id {item.ItemId}" +
        $"\n item name {item.ItemName}" +
        $"\n item quanity {item.Quantity}");
}