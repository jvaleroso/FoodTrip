using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTrip.Dao;

namespace FoodTrip.Services
{
    public class MenuService : IMenuService
    {
        public readonly IMenuDao _menuDao;

        public MenuService(IMenuDao menuDao)
        {
            _menuDao = menuDao;
        }

        public Menu Save(Menu menu)
        {
            return _menuDao.Save(menu);
        }

        public void Delete(Menu menu)
        {
            _menuDao.Delete(menu);
        }

        public Menu GetMenu(long id)
        {
            return _menuDao.GetMenu(id);
        }

        public IList<Menu> GetList()
        {
            return _menuDao.GetList();
        }


        public void Publish(Menu menu)
        {
            menu.MenuStatus = MenuStatus.Published;
            _menuDao.Save(menu);
        }


        public Menu SaveNew(Menu menu, User user)
        {
            menu.MenuStatus = MenuStatus.Draft;
            menu.Vendor = user;
            return _menuDao.Save(menu);
        }
    }
}
