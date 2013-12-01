using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Dao.NHibernate.Repo
{
    public class UserRepo
    {
        public virtual long Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string FullName { get; set; }
        public virtual string ContactNo { get; set; }
        public virtual string Email { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual IList<MenuRepo> MenuList { get; protected set; } 
    }
}
