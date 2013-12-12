using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Dao.NHibernate.Repo
{
    public class MenuItemRepo
    {
        public virtual long Id { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int OrderQuantity { get; set; }
        public virtual decimal Price { get; set; }
        public virtual MenuRepo Menu { get; set; }
        public virtual FoodRepo Food { get; set; }
    }
}
