using System;
using System.Collections.Generic;
using AutoMapper;
using FoodTrip.Dao.NHibernate.Repo;

namespace FoodTrip.Dao.NHibernate.Dao
{
    public class MenuItemDao: IMenuItemDao
    {
        public IList<MenuItem> GetList()
        {
            return Mapper.Map<IList<MenuItem>>(NH.Select(s => s.QueryOver<MenuItemRepo>().List()));
        }

        public void Delete(MenuItem menuItem)
        {
            NH.Run(s => s.Delete(Mapper.Map<MenuItemRepo>(menuItem)));
        }

        public MenuItem GetMenu(long id)
        {
            return Mapper.Map<MenuItem>(NH.Select(s => s.Get<MenuItemRepo>(id)));
        }

        public MenuItem Save(MenuItem menuItem)
        {
            var menuItemRepo = Mapper.Map<MenuItemRepo>(menuItem);
            NH.Run(s => s.SaveOrUpdate(menuItemRepo));
            return Mapper.Map<MenuItem>(menuItemRepo);
        }
    }
}
