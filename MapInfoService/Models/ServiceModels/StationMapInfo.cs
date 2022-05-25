using MapInfoService.Models.DBModels;

namespace MapInfoService.Models.ServiceModels
{
    public class StationMapInfo : MapInfoBase
    {
        public string? Description { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }

        public static explicit operator StationMapInfo(Station station)
        {
            return new StationMapInfo()
            {
                Description = station.Description,
                Name = station.Name,
                Position = station.Position,
                Latitude = station.Latitude,
                Longitude = station.Longitude,
            };
        }
        public static Station operator +(Station station, StationMapInfo stationMapInfo)
        {
            station.Description = stationMapInfo.Description;
            station.Name = stationMapInfo.Name;
            station.Position = stationMapInfo.Position;
            station.Latitude = (float)stationMapInfo.Latitude;
            station.Longitude = (float)stationMapInfo.Longitude;

            return station;
        }
    }
}
