using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip
{
    public class Menu
    {
        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public MenuStatus MenuStatus { get; set; }
        public User Vendor { get; set; }
        public IList<MenuItem> MenuItems { get; private set; }
    }
}
