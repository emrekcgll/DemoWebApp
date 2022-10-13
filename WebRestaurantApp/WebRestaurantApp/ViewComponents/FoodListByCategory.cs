using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurantApp.ViewComponents
{
    public class FoodListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            FoodRepository foodRepository = new FoodRepository();
            var value = foodRepository.List(x => x.CategoryId == id);
            return View(value);
        }
    }
}
