using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F5WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F5Controller : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            await Task .Delay(500);

            return Ok("Hello Yogesh");
        }
    }
}
