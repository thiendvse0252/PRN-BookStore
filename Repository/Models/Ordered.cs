using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Ordered
    {
        public Ordered()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Username { get; set; }
        public int TotalPayment { get; set; }

        public virtual Registration UsernameNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
