using SampleMVC.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class MenuController : Controller
    {
        private MenuService menuService;

        public MenuController()
        {
            menuService = new MenuService();
        }

        public ActionResult Index()
        {
            var menuItems = menuService.GetActiveMenuItems();
            return View(menuItems);
        }
    }

}