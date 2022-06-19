using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Concrete
{
    public class Order //Entity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public decimal TotalPrice { get { return OrderDetails.Sum(x => x.Price); } set { } }
    }
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
