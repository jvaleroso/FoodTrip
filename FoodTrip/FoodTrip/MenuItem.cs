using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip
{
    public class MenuItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public Menu Menu { get; set; }
        public Food Food { get; set; }
    }
}
