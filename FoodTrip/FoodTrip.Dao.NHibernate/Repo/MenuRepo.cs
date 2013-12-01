using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Dao.NHibernate.Repo
{
    public class MenuRepo
    {
        public virtual long Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual MenuStatus MenuStatus { get; set; }
        public virtual UserRepo Vendor { get; set; }
        public virtual IList<MenuItemRepo> MenuItems { get; protected set; } 
    }
}
