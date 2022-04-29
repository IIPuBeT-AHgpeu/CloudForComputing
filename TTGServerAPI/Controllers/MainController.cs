using Microsoft.AspNetCore.Mvc;
using TTGServerAPI.Services;

namespace TTGServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public string TestGet()
        {
            InfoService service = new InfoService(new TTG_ver3Context());
            return "OK";
        }
    }
}