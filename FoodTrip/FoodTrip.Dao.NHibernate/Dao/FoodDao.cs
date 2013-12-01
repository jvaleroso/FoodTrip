using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodTrip.Dao.NHibernate.Repo;

namespace FoodTrip.Dao.NHibernate.Dao
{
    public class FoodDao: IFoodDao
    {
        public Food Save(Food food)
        {
            var foodRepo = Mapper.Map<FoodRepo>(food);
            NH.Run(s=>s.SaveOrUpdate(foodRepo));
            return Mapper.Map<Food>(foodRepo);
        }

        public void Delete(Food food)
        {
            NH.Run(s=>s.Delete(Mapper.Map<FoodRepo>(food)));
        }

        public Food GetFood(long id)
        {
            return Mapper.Map<Food>(NH.Select(s => s.Get<FoodRepo>(id)));
        }

        public IList<Food> GetList()
        {
            return Mapper.Map<IList<Food>>(NH.Select(s => s.QueryOver<FoodRepo>().List()));
        }
    }
}
