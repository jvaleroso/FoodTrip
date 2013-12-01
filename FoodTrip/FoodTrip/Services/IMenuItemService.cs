using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Services
{
    public interface IMenuItemService
    {
        IList<MenuItem> GetList();
        void Delete(MenuItem menuItem);
        MenuItem GetMenu(long id);
        MenuItem Save(MenuItem menuItem);
    }
}
