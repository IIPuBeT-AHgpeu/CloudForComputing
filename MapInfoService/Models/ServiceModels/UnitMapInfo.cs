using MapInfoService.Models.DBModels;

namespace MapInfoService.Models.ServiceModels
{
    public class UnitMapInfo : MapInfoBase
    {
        public string Number { get; set; } = null!;
        public bool IsFull { get; set; }

        static public explicit operator UnitMapInfo(Unit unit)
        {
            return new UnitMapInfo()
            {
                Number = unit.Number,
                Latitude = unit.Latitude,
                Longitude = unit.Longitude,
                IsFull = unit.IsFull,
            };
        }
        static public Unit operator +(Unit unit, UnitMapInfo unitMapInfo)
        {
            unit.Latitude = unitMapInfo.Latitude;
            unit.Longitude = unitMapInfo.Longitude;
            unit.IsFull = unitMapInfo.IsFull;

            return unit;
        }
    }
}
