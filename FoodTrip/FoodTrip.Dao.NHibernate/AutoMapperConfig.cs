using System.Runtime.Remoting;
using AutoMapper;
using FoodTrip.Dao.NHibernate.Repo;

namespace FoodTrip.Dao.NHibernate
{
    public static class AutoMapperConfig
    {
        public static void RegisterTypes()
        {
            Mapper.CreateMap<User, UserRepo>();
            Mapper.CreateMap<UserRepo, User>();
            Mapper.CreateMap<MenuItem, MenuItemRepo>();
            Mapper.CreateMap<MenuItemRepo, MenuItem>();
            Mapper.CreateMap<Food, FoodRepo>();
            Mapper.CreateMap<FoodRepo, Food>();
            Mapper.CreateMap<Menu, MenuRepo>();
            Mapper.CreateMap<MenuRepo, Menu>();
        }
    }
}

