using InfoService;
using Microsoft.AspNetCore.Mvc;

namespace TTGServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet(@"GetWayNamesList")]
        public IEnumerable<string> GetWayNamesList()
        {
            Service service = new Service(new TTG_ver3Context());

            return service.GetAllWayNames();
        }

        [HttpPut(@"UpdateUnitStatus/{number}")]
        public void PutUnitStatus(string number, [FromBody]string newStatus)
        {
            Service service = new Service(new TTG_ver3Context());

            service.UpdateUnitStatus(number, newStatus);
        }

        [HttpGet]
        public string Get()
        {
            return "OK";
        }
    }
}