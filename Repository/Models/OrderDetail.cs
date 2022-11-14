using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; }
        public string BookId { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual Ordered Order { get; set; }
    }
}
