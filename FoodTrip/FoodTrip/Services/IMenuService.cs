using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Services
{
    public interface IMenuService
    {
        Menu Save(Menu menu);
        Menu SaveNew(Menu menu, User user);
        void Delete(Menu menu);
        Menu GetMenu(long id);
        IList<Menu> GetList();
        void Publish(Menu menu);
    }
}
