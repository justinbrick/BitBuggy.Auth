using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitBuggy.Auth.Controllers;


[Route("auth")]
[ApiController]
public class AuthorizationController : ControllerBase
{
    [HttpGet("status")]
    public IActionResult Get()
    {
        return Ok("Good to go!");
    }
}
