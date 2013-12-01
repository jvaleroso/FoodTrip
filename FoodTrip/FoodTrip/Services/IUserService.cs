using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrip.Services
{
    public interface IUserService
    {
        User Save(User user);
        User GetById(long id);
        User ValidateUser(string username, string password);
        void Delete(User user);
        User GetByUsername(string username);
        void AddMenu(User user, Menu menu);
    }
}
