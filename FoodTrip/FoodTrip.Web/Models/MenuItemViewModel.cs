using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTrip.Web.Models
{
    public class MenuItemViewModel
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
        public long FoodId { get; set; }
    }
}