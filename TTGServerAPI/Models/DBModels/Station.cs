using System;
using System.Collections.Generic;

namespace TTGServerAPI
{
    public partial class Station
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int WayId { get; set; }
        public int Position { get; set; }
        public int? Waiting { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Name { get; set; } = null!;

        public virtual Way Way { get; set; } = null!;
    }
}
