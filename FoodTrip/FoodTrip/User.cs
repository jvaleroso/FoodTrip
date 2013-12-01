using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip
{
    public class User   
    {
        public User()
        {
            MenuList = new List<Menu>();
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public IList<Menu> MenuList { get; set; } 
    }
}
