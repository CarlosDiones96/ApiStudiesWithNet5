using Microsoft.AspNetCore.Mvc;

namespace UrlVersioning.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/awesome")]
    public class AwesomeController : Controller
    {
        public IActionResult Get() => Ok("Version 1");
    }
}

namespace UrlVersioning.Controllers.V2
{

    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/awesome")]
    public class AwesomeController : Controller
    {
        public IActionResult Get() => Ok($"Version 2 - {Request.HttpContext.Connection.Id}");
    }
}