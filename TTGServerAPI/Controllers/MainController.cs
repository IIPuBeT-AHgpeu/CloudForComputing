using Microsoft.AspNetCore.Mvc;
using TTGServerAPI.Models.ServiceModels;
using TTGServerAPI.Services;

namespace TTGServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        [HttpGet(@"MapInfo/GetUnits/{wayName}")]
        public IEnumerable<UnitMapInfo> GetUnitsMapInfo(string wayName)
        {
            MapInfoService service = new MapInfoService(new TTG_ver3Context());

            return service.GetUnitsMapInfoByWayName(wayName);
        }

        [HttpPut(@"MapInfo/UpdateUnit")]
        public void PutUnitMapInfo([FromBody]UnitMapInfo unitMapInfo)
        {
            MapInfoService service = new MapInfoService(new TTG_ver3Context());

            service.UpdateUnitMapInfo(unitMapInfo);
        }

        [HttpGet(@"MapInfo/GetStations/{wayName}")]
        public IEnumerable<StationMapInfo> GetStationsMapInfo(string wayName)
        {
            MapInfoService service = new MapInfoService(new TTG_ver3Context());

            return service.GetStationsMapInfoByWayName(wayName);
        }
    }
}