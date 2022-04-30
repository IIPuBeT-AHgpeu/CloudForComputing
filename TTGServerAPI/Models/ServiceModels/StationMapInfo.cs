namespace TTGServerAPI.Models.ServiceModels
{
    public class StationMapInfo
    {
        public string? Description { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public int? Waiting { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public static explicit operator StationMapInfo(Station station)
        {
            return new StationMapInfo()
            {
                Description = station.Description,
                Name = station.Name,
                Position = station.Position,
                Waiting = station.Waiting,
                Latitude = station.Latitude,
                Longitude = station.Longitude,
            };
        }
        public static Station operator +(Station station, StationMapInfo stationMapInfo)
        {
            station.Description = stationMapInfo.Description;
            station.Name = stationMapInfo.Name;
            station.Position = stationMapInfo.Position;
            station.Waiting = stationMapInfo.Waiting;
            station.Latitude = stationMapInfo.Latitude;
            station.Longitude = stationMapInfo.Longitude;

            return station;
        }
    }
}
