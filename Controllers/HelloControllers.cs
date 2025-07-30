using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtSecureApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Authorize] // 
        public IActionResult Get()
        {
            return Ok("you are not allowed to access without Tocken.");
        }
    }
}
