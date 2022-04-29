using System;
using System.Collections.Generic;

namespace TTGServerAPI
{
    public partial class Owner
    {
        public Owner()
        {
            Ways = new HashSet<Way>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? License { get; set; }

        public virtual ICollection<Way> Ways { get; set; }
    }
}
