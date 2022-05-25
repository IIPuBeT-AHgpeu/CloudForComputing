using MapInfoService.Models.ServiceModels;
using Microsoft.AspNetCore.Mvc;

namespace MapInfoService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapInfoController : ControllerBase
    {
        [HttpGet(@"MapInfo/GetUnits/{wayName}")]
        public IEnumerable<UnitMapInfo> GetUnitsMapInfo(string wayName)
        {
            Service service = new Service(new TTG_ver3Context());

            return service.GetUnitsMapInfoByWayName(wayName);
        }

        [HttpPut(@"MapInfo/UpdateUnit")]
        public void PutUnitMapInfo([FromBody] UnitMapInfo unitMapInfo)
        {
            Service service = new Service(new TTG_ver3Context());

            service.UpdateUnitMapInfo(unitMapInfo);
        }

        [HttpGet(@"MapInfo/GetStations/{wayName}")]
        public IEnumerable<StationMapInfo> GetStationsMapInfo(string wayName)
        {
            Service service = new Service(new TTG_ver3Context());

            return service.GetStationsMapInfoByWayName(wayName);
        }
    }
}