namespace Ozon.Edu.StockAPI.Models.Common;
public class StockItem
{
    public StockItem(long itemId, string itemName, int quanity)
    {
        ItemId = itemId;
        ItemName = itemName;
        Quanity = quanity;
    }
    public long ItemId { get; }

    public string ItemName { get; }
    public int Quanity { get; }
}
