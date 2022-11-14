using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public int Price { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
