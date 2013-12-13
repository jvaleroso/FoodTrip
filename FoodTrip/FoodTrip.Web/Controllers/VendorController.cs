using System.Web.Mvc;
using FoodTrip.Services;
using FoodTrip.Web.Models;
using Microsoft.AspNet.Identity;

namespace FoodTrip.Web.Controllers
{
    [Authorize(Roles = "Vendor")]
    public class VendorController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMenuService _menuService;

        public VendorController(IUserService userService, IMenuService menuService)
        {
            _userService = userService;
            _menuService = menuService;
        }

        public ActionResult Index()
        {
            var user = _userService.GetByUsername(User.Identity.GetUserName());
            return View(user.MenuList);
        }

        public ActionResult Menu(int id)
        {
            var menu = _menuService.GetMenu(id);

            if (menu == null)
                return RedirectToAction("Index");

            var menuViewModel = new MenuViewModel
            {
                Id = menu.Id,
                Date = menu.Date,
                MenuItems = menu.MenuItems,
            };

            return View(menuViewModel);
        }

        [HttpPost]
        public ActionResult Update(MenuViewModel menu)
        {
            var _menu = _menuService.GetMenu(menu.Id);
            _menu.Date = menu.Date;
            _menuService.Save(_menu);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MenuViewModel menu)
        {
            var _menu = new Menu { Date = menu.Date };
            if (!ModelState.IsValid) return RedirectToAction("Index");

            var user = _userService.GetByUsername(User.Identity.Name);

            _menuService.SaveNew(_menu, user);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Publish(MenuViewModel menu)
        {
            var _menu = _menuService.GetMenu(menu.Id);

            _menuService.Publish(_menu);

            return RedirectToAction("Index");
        }
    }
}