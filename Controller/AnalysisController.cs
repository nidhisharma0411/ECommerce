[ApiController]
[Route("api/[controller]")]
public class AnalysisController : ControllerBase
{
    private readonly SalesDbContext _context;

    public AnalysisController(SalesDbContext context)
    {
        _context = context;
    }

    [HttpGet("total-revenue")]
    public async Task<IActionResult> GetTotalRevenue(DateTime startDate, DateTime endDate)
    {
        var totalRevenue = await _context.Orders
            .Where(o => o.DateOfSale >= startDate && o.DateOfSale <= endDate)
            .SumAsync(o => o.TotalPrice);

        return Ok(totalRevenue);
    }
}
