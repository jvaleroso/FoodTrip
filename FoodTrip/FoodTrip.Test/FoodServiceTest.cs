using System;
using FakeItEasy;
using FoodTrip.Dao;
using FoodTrip.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoodTrip.Test
{
    [TestClass]
    public class FoodServiceTest
    {
        [TestMethod]
        public void FoodCreate()
        {
            var foodDao = A.Fake<IFoodDao>();

            var foodService = new FoodService(foodDao);

            var food = new Food
            {
                Description = "Pritong Galunggong",
                Name = "Pritong Galunggong",
            };

            A.CallTo(() => foodDao.Save(food)).Returns(food);

            var returnedFood = foodService.Save(food);

            Assert.AreEqual("Pritong Galunggong", returnedFood.Name);
            Assert.AreEqual("Pritong Galunggong", returnedFood.Description);
        }
    }
}
