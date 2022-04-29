using System;
using System.Collections.Generic;

namespace TTGServerAPI
{
    public partial class Trip
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly? TimeEnd { get; set; }
        public int WorkdayId { get; set; }

        public virtual WorkDay Workday { get; set; } = null!;
    }
}
