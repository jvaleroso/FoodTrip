using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Services
{
    public interface IMenuService
    {
        Menu Save(Menu menu);
        void Delete(Menu menu);
        Menu GetMenu(long id);
        IList<Menu> GetList();
    }
}
