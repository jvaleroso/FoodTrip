using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTrip.Dao;

namespace FoodTrip.Services
{
    public class MenuItemService: IMenuItemService
    {
        public readonly IMenuItemDao _menuItemDao;

        public MenuItemService(IMenuItemDao menuItemDao)
        {
            _menuItemDao = menuItemDao;
        }

        public IList<MenuItem> GetList()
        {
            return _menuItemDao.GetList();
        }

        public void Delete(MenuItem menuItem)
        {
            _menuItemDao.Delete(menuItem);
        }

        public MenuItem GetMenu(long id)
        {
           return _menuItemDao.GetMenu(id);
        }

        public MenuItem Save(MenuItem menuItem)
        {
            return _menuItemDao.Save(menuItem);
        }
    }
}
