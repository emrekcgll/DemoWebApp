using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurantApp.ViewComponents
{
    public class CategoryGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository cr = new CategoryRepository();
            var categoryList = cr.TList();
            return View(categoryList);
        }
    }
}
