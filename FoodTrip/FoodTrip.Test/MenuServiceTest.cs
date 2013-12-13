using System;
using FakeItEasy;
using FoodTrip.Dao;
using FoodTrip.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoodTrip.Test
{
    [TestClass]
    public class MenuServiceTest
    {
        [TestMethod]
        public void TestSaveNew()
        {
            var menuDao = A.Fake<IMenuDao>();
            var menuService = new MenuService(menuDao);

            var user = new User()
            {
                ContactNo = "123456",
                Email = "vale@gmail.com",
                FullName = "Jayson Valeroso",
                Username = "jvalero"
            };

            var newMenu = new Menu()
            {
                Date = DateTime.Now
            };

            A.CallTo(() => menuDao.Save(newMenu)).Returns(newMenu);

            var savedMenu = menuService.SaveNew(newMenu, user);

            Assert.AreEqual(MenuStatus.Draft, savedMenu.MenuStatus);
            Assert.AreEqual("jvalero", savedMenu.Vendor.Username);
        }

        [TestMethod]
        public void TestPublishMenu()
        {
            var menuDao = A.Fake<IMenuDao>();
            var menuService = new MenuService(menuDao);

            var menu = new Menu()
            {
                Date = DateTime.Now
            };

            A.CallTo(() => menuDao.Save(menu)).Returns(menu);

            menuService.Publish(menu);

            Assert.AreEqual(MenuStatus.Published, menu.MenuStatus);
        }
    }
}
