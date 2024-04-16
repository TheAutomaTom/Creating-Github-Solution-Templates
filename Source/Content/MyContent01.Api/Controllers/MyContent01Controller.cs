using Microsoft.AspNetCore.Mvc;

namespace MyContent01.Controllers
{
  [ApiController]
  [Route("[controller]/[action]")]
  public class MyContent01Controller : ControllerBase
  {
    private readonly ILogger<MyContent01Controller> _logger;

    public MyContent01Controller(ILogger<MyContent01Controller> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult GetMyContent01()
    {
      return Ok("Hello world, from MyContent01!");
    }
  }
}
