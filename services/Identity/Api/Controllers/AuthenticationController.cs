namespace Api;

using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult HelloWorld()
    {
        return Ok("Hello World");
    }
}