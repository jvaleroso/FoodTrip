using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTrip.Dao;

namespace FoodTrip.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDao _userDao;

        public UserService(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public User Save(User user)
        {
            return _userDao.Save(user);
        }

        public User GetById(long id)
        {
            return _userDao.GetById(id);
        }

        public User ValidateUser(string username, string password)
        {
            var user = _userDao.ValidateUser(username, password);
            return user;
        }

        public void Delete(User user)
        {
            _userDao.Delete(user);
        }

        public User GetByUsername(string username)
        {
           return _userDao.GetByUsername(username);
        }

        public void AddMenu(User user, Menu menu)
        {
            _userDao.AddMenu(user, menu);
        }
    }
}
