namespace Ozon.Edu.StockAPI.Services;

public class StockService : IStockSerice
{
    private readonly List<StockItem> StockItems = new List<StockItem>()
    {
        new StockItem(1,"футболка", 10),
        new StockItem(2,"Толстовка", 20),
        new StockItem(3,"Кепка", 15)
    };

    

    public async Task<List<StockItem>> GetAll(CancellationToken cts) => StockItems;

    public async Task<StockItem> GetById(long id, CancellationToken cts)
    {
        var item = StockItems.FirstOrDefault(s => s.ItemId == id);
        return item;
    }

    public async Task<StockItem> Update(long id, StockItemUpdateModel model, CancellationToken cts)
    {
        var newItem = StockItems.FirstOrDefault(s => s.ItemId == id);
        
        if (newItem == null) return null;

        var itemToUpdate = new StockItem(id, model.ItemName, model.Quanity);

        StockItems.Add(itemToUpdate);
        return newItem;
        
    }
    public async Task<StockItem> Add(StockItemCreationModel stockItem, CancellationToken cts)
    {

        var newItem = new StockItem(
            StockItems.Max(s => s.ItemId) + 1,
            stockItem.ItemName,
            stockItem.Quanity
            );

        StockItems.Add(newItem);

        return newItem;
    }
}

