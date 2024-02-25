using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;
namespace BitBuggy.Auth.Controllers;

[Route("oauth2")]
[ApiController]
public class AuthorizationController : ControllerBase
{
    [HttpPost("token")]
    public IActionResult PostTokenRequest(TokenRequest request)
    {
        return Ok();
    }
}
