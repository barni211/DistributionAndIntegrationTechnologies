using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class KitchenDishes : IDishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderDestination Type = OrderDestination.Kitchen;
        public decimal Price { get; set; }
    }
}
