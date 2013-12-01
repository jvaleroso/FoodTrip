using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Dao
{
    public interface IFoodDao
    {
        Food Save(Food food);
        void Delete(Food food);
        Food GetFood(long id);
        IList<Food> GetList();
    }
}
