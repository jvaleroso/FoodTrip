using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FoodTrip.Services;
using FoodTrip.Web.Models;

namespace FoodTrip.Web.Controllers
{
    public class MenuItemController : Controller
    {
        //
        // GET: /MenuItem/
        private readonly IMenuItemService _menuItemService;
        private readonly IFoodService _foodService;
        private readonly IMenuService _menuService;

        public MenuItemController(
              IMenuItemService menuItemService
            , IFoodService foodService
            , IMenuService menuService)
        {
            _menuItemService = menuItemService;
            _foodService = foodService;
            _menuService = menuService;
        }

        public ActionResult AddMenuItem(long menuId)
        {
            var foodList = _foodService.GetList();
            ViewBag.FoodList = new SelectList(foodList, "Id",  "Name");
            return this.View();
        }

        [HttpPost]
        public ActionResult AddMenuItem(MenuItemViewModel menuItem, long menuId)
        {
            var _menuItem = new MenuItem();
            var _menu = _menuService.GetMenu(menuId);
            var _food = _foodService.GetFood(menuItem.FoodId);
            _menuItem.OrderQuantity = menuItem.OrderQuantity;
            _menuItem.Quantity = menuItem.Quantity;
            _menuItem.Price = menuItem.Price;
            _menuItem.Food = _food;
            _menuItem.Menu = _menu;
            _menuItemService.Save(_menuItem);

            return RedirectToAction("Menu", "Vendor", new { Id = menuId });
        }
    }
}