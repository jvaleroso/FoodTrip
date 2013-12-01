using System.Collections.Generic;

namespace FoodTrip.Dao
{
    public interface IMenuItemDao
    {
        IList<MenuItem> GetList();
        void Delete(MenuItem menuItem);
        MenuItem GetMenu(long id);
        MenuItem Save(MenuItem menuItem);
    }
}
