namespace StatsTennisAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StatsTennisAPIController : ControllerBase
{
    private readonly ILogger<StatsTennisAPIController> _logger;

    public StatsTennisAPIController(ILogger<StatsTennisAPIController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTennisPlayers")]
    public async Task<IEnumerable<TennisPlayer>> Get(string path)
    {
        FileStream input = System.IO.File.OpenRead(path);
        var options = new JsonSerializerOptions { WriteIndented = true };
        IEnumerable<TennisPlayer> toJsonInput = await JsonSerializer.DeserializeAsync<IEnumerable<TennisPlayer>>(input,options);
        return toJsonInput != null ? toJsonInput : new List<TennisPlayer>();
    }
}
