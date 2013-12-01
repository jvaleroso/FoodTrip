using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodTrip.Dao.NHibernate.Repo;

namespace FoodTrip.Dao.NHibernate.Dao
{
    public class MenuDao: IMenuDao
    {
        public Menu Save(Menu menu)
        {
            var menuRepo = Mapper.Map<MenuRepo>(menu);
            NH.Run(s=>s.SaveOrUpdate(menuRepo));
            return Mapper.Map<Menu>(menuRepo);
        }

        public void Delete(Menu menu)
        {
            NH.Run(s=>s.Delete(Mapper.Map<MenuRepo>(menu)));
        }

        public Menu GetMenu(long id)
        {
            return Mapper.Map<Menu>(NH.Select(s => s.Get<MenuRepo>(id)));
        }

        public IList<Menu> GetList()
        {
            return Mapper.Map<IList<Menu>>(NH.Select(s => s.QueryOver<MenuRepo>().List()));
        }
    }
}
