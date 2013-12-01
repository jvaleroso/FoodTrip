using System.Collections.Generic;
using FoodTrip.Dao;

namespace FoodTrip.Services
{
    public class FoodService : IFoodService
    {
        public readonly IFoodDao _foodDao;

        public FoodService(IFoodDao foodDao)
        {
            _foodDao = foodDao;
        }

        public Food Save(Food food)
        {
            return _foodDao.Save(food);
        }

        public void Delete(Food food)
        {
            _foodDao.Delete(food);
        }

        public Food GetFood(long id)
        {
            return _foodDao.GetFood(id);
        }

        public IList<Food> GetList()
        {
            return _foodDao.GetList();
        }
    }
}
