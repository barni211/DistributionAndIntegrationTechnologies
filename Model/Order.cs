using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Order
    {
        public string OrderId { get; set; }
        public int TableNumber { get; set; }
        public OrderStatus Status { get; set; }
        public OrderDestination Destination { get; set; }
        public IList<IDishes> Dishes { get; set; }
    }
}
