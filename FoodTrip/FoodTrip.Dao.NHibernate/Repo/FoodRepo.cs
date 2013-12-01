using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Dao.NHibernate.Repo
{
    public class FoodRepo
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<MenuItemRepo> MenuItems { get; set; }
    }
}
