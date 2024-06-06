[ApiController]
[Route("api/[controller]")]
public class DataRefreshController : ControllerBase
{
    private readonly IBackgroundJobClient _backgroundJobs;

    public DataRefreshController(IBackgroundJobClient backgroundJobs)
    {
        _backgroundJobs = backgroundJobs;
    }

    [HttpPost("refresh")]
    public IActionResult RefreshData()
    {
        _backgroundJobs.Enqueue<CsvLoader>(loader => loader.LoadDataAsync("D:/lumel_project/sample.csv"));
        return Ok("Data refresh job triggered.");
    }
}
