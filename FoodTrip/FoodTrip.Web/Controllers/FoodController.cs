using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using FoodTrip.Services;

namespace FoodTrip.Web.Controllers
{
    [Authorize(Roles = "Vendor")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            this._foodService = foodService;
        }

        public ActionResult Index()
        {
            var foodList = _foodService.GetList();
            return View(foodList);
        }

        public ActionResult Edit(long id)
        {
            var food = _foodService.GetFood(id);
            return this.View(food);
        }

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            _foodService.Save(food);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            var food = _foodService.GetFood(id);
            return this.View(food);
        }

        public ActionResult Delete(long id)
        {
            var food = _foodService.GetFood(id);
            _foodService.Delete(food);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Food food)
        {
            _foodService.Save(food);
            return RedirectToAction("Index");
        }
    }
}