using Microsoft.AspNetCore.Mvc;

namespace VersioningOptions.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    public class NamesController : Controller
    {
        [MapToApiVersion("1.0")]
        public IActionResult Get()
        {
            return Ok("Some info from v1.0");
        }

        [MapToApiVersion("2.0")]
        public IActionResult Put(string name)
        {
            return Ok();
        }
    }
}