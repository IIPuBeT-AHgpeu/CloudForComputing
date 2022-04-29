using Microsoft.AspNetCore.Mvc;

namespace TTGServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public string TestGet()
        {
            return "OK";
        }
    }
}