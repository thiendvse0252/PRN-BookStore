using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Registration
    {
        public Registration()
        {
            Ordereds = new HashSet<Ordered>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool Role { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Ordered> Ordereds { get; set; }
    }
}
