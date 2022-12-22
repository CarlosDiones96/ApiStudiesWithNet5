using Microsoft.AspNetCore.Mvc;

namespace HeaderVersioning.Controllers.V1
{
    [ApiVersion("1.0")]
    public class AwesomeController : Controller
    {
        public IActionResult Get() => Ok("Version 1");
    }
}

namespace HeaderVersioning.Controllers.V2
{
    [ApiVersion("2.0")]
    public class AwesomeController : Controller
    {
        public IActionResult Get() => Ok($"Version 2 - {Request.HttpContext.Connection.Id}");
    }
}