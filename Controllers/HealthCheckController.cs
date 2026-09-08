
using Microsoft.AspNetCore.Mvc;

namespace DbApi.Controllers;

[ApiController]
[Route("health")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public IActionResult HealthCheck()
    {
        // return StatusCode(200, "Healthy");
        return Ok("Healthy");
    }
}