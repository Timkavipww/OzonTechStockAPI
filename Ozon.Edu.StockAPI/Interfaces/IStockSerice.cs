namespace Ozon.Edu.StockAPI.Interfaces;

public interface IStockSerice
{
    Task<List<StockItem>> GetAll(CancellationToken cts);
    Task<StockItem> GetById(long id, CancellationToken cts);
    Task<StockItem> Add(StockItemCreationModel item, CancellationToken cts);
    Task<StockItem> Update(long id, StockItemUpdateModel model, CancellationToken cts);
}