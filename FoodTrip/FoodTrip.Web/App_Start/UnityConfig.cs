using System;
using FoodTrip.Dao;
using FoodTrip.Dao.NHibernate.Dao;
using FoodTrip.Services;
using Microsoft.Practices.Unity;

namespace FoodTrip.Web.App_Start
{
    public static class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(CreateContainer);

        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }

        public static UnityContainer CreateContainer()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterInstance(unityContainer);

            unityContainer.RegisterType<IMenuDao, MenuDao>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IUserDao, UserDao>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IFoodDao, FoodDao>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IMenuItemDao, MenuItemDao>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IMenuService, MenuService>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IUserService, UserService>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IFoodService, FoodService>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IMenuItemService, MenuItemService>(new ContainerControlledLifetimeManager());

            return unityContainer;
        }
    }
}