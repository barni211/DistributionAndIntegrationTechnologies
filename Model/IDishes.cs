using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public abstract class IDishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderDestination Type { get; set; }
        public decimal Price { get; set; }
        public OrderStatus Status { get; set; }
    }
}
