using System;
using System.Collections.Generic;

namespace TTGServerAPI
{
    public partial class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
