using MapInfoService.Models.DBModels;
using MapInfoService.Models.ServiceModels;

namespace MapInfoService
{
    public class Service
    {
        public TTG_ver3Context? Context { get; set; }
        public Service(TTG_ver3Context? context)
        {
            if (context == null)
                throw new Exception("Invalid DB context!");
            else
                Context = context;
        }
        public IEnumerable<UnitMapInfo> GetUnitsMapInfoByWayName(string wayName)
        {
            //Get wayId by wayName
            int wayId = Context.Ways.First(way => way.Name == wayName).Id;

            List<UnitMapInfo> unitMapInfos = new List<UnitMapInfo>();
            List<Unit> units = Context.Units.Where(unit => unit.WayId == wayId).ToList();

            foreach (var unit in units)
            {
                unitMapInfos.Add((UnitMapInfo)unit);
            }

            return unitMapInfos;
        }
        public void UpdateUnitMapInfo(UnitMapInfo unitMapInfo)
        {
            //Get unit from DB by number
            Unit unit = Context.Units.First(unit => unit.Number == unitMapInfo.Number);

            unit += unitMapInfo;
            Context.SaveChanges();
        }
        public IEnumerable<StationMapInfo> GetStationsMapInfoByWayName(string wayName)
        {
            //Get wayId by wayName
            int wayId = Context.Ways.First(way => way.Name == wayName).Id;

            List<StationMapInfo> stationMapInfos = new List<StationMapInfo>();
            List<Station> stations = Context.Stations.Where(station => station.WayId == wayId).ToList();

            foreach (var station in stations)
            {
                stationMapInfos.Add((StationMapInfo)station);
            }

            return stationMapInfos;
        }
    }
}