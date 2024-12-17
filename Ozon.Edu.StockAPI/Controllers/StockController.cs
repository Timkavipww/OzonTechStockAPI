namespace Ozon.Edu.StockAPI.Controllers;

[ApiController]
[Route("v1/api/stocks")]
[Produces("application/json")]
public class StockController : ControllerBase
{
    private readonly IStockSerice _stockSerice;

    public StockController(IStockSerice stockService)
    {
        _stockSerice = stockService;
    }


    /// <summary>
    /// Getting all Stock Items
    /// </summary>
    /// <param name="cts"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<StockItem>), 200)]
    public async Task<ActionResult<List<StockItemResponse>>> GetAll(CancellationToken cts)
    {
        var items = await _stockSerice.GetAll(cts);

        return Ok(items);
    }

    [HttpGet("{id}")]
    //[ProducesResponseType(404)]
    public async Task<ActionResult<StockItemResponse>> GetById(long id, CancellationToken cts)
    {
        var item = await _stockSerice.GetById(id, cts);
        if (item == null) return NotFound();

        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<StockItemResponse>> Add(StockItem model, CancellationToken cts)
    {

        var createdStockItem = await _stockSerice.Add(new StockItemCreationModel
        {
            ItemName = model.ItemName,
            Quanity = model.Quanity,
        }, cts);

        return Ok(createdStockItem);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<StockItemResponse>> Update(long id,[FromBody] StockItem model, CancellationToken cts)
    {
        

        return Ok();
    }
}

