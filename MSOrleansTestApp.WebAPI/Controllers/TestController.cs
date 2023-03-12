using Microsoft.AspNetCore.Mvc;

namespace MSOrleansTestApp.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Say")]
    public string Get()
    {
        return "Hello World";
    }
}