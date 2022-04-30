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

        [HttpGet(@"Info/GetWayNamesList")]
        public IEnumerable<string> GetWayNamesList()
        {
            InfoService service = new InfoService(new TTG_ver3Context());

            return service.GetAllWayNames();
        }

        [HttpPut(@"Info/UpdateOwner/{currentLogin}")]
        public void PutOwnerInfo(string currentLogin, [FromBody]OwnerServiceModel owner)
        {
            //to be continue...
        }

        [HttpPut(@"Info/UpdateUnitStatus/{number}")]
        public void PutUnitStatus(string number, [FromBody]string newStatus)
        {
            InfoService service = new InfoService(new TTG_ver3Context());

            service.UpdateUnitStatus(number, newStatus);
        }

        [HttpGet(@"Authorization/Login/{category}&{login}&{password}")]
        public IProfileServiceModel GetAuthorization(char category, string login, string password)
        {
            AuthorizationService service = new AuthorizationService(new TTG_ver3Context());

            return service.LogIn(category, login, password);
        }
    }
}