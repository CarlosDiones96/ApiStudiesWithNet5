using Microsoft.AspNetCore.Mvc;

namespace BasicVersioning.Controllers
{
    [Route("api/awesome")]
    public class AwesomeV1Controller : Controller
    {
        public IActionResult Get() => Ok("Version 1");
    }
}