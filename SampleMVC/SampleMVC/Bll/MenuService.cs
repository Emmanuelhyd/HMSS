using SampleMVC.Dal;
using SampleMVC.Models.SampleDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Bll
{
    public class MenuService
    {
        private MenuRepository menuRepository;

        public MenuService()
        {
            menuRepository = new MenuRepository();
        }

        public List<MenuItem> GetActiveMenuItems()
        {
            return menuRepository.GetMenuItems();
        }
    }

}