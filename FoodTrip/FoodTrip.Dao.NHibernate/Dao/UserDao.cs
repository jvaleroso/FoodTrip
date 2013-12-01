using System.Threading.Tasks;
using AutoMapper;
using FoodTrip.Dao.NHibernate.Repo;

namespace FoodTrip.Dao.NHibernate.Dao
{
    public class UserDao : IUserDao
    {
        public User Save(User user)
        {
            var userRepo = Mapper.Map<UserRepo>(user);
            NH.Run(s => s.SaveOrUpdate(userRepo));
            return Mapper.Map<User>(userRepo);
        }

        public User GetById(long id)
        {
            return Mapper.Map<User>(NH.Select(s => s.Get<UserRepo>(id)));
        }

        public User ValidateUser(string username, string password)
        {
            var userRepo = NH.Select(
                s => s.QueryOver<UserRepo>()
                    .Where(u => u.Username == username)
                    .And(u => u.Password == password).SingleOrDefault());
            var user = Mapper.Map<User>(userRepo);

            return user;
        }

        public void Delete(User user)
        {
            NH.Run(s => s.Delete(user));
        }

        public User GetByUsername(string username)
        {
            var userRepo = NH.Select(s => s.QueryOver<UserRepo>()
                .Where(u => u.Username == username)
                .SingleOrDefault());

            return userRepo == null ? null : Mapper.Map<User>(userRepo);
        }

        public void AddMenu(User user, Menu menu)
        {
            if (menu == null) return;

            menu.MenuStatus = MenuStatus.Draft;

            user.MenuList.Add(menu);

            NH.Run(s => s.SaveOrUpdate(user));
        }
    }
}
