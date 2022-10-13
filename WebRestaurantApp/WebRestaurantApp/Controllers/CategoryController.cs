using DataAccessLayer.Concrete;
using DataAccessLayer.Entity;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurantApp.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        CategoryRepository cr = new CategoryRepository();
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(cr.List(x => x.CategoryName == p));
            }
            return View(cr.TList());
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = cr.TGet(id);
            value.CategoryStatus = false;
            cr.TUpdate(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            cr.TAdd(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var value = cr.TGet(id);
            Category ct = new Category()
            {
                CategoryName = value.CategoryName,
                CategoryDescription = value.CategoryDescription,
                CategoryId = value.CategoryId
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            var value = cr.TGet(category.CategoryId);
            value.CategoryName = category.CategoryName;
            value.CategoryDescription = category.CategoryDescription;
            value.CategoryStatus = true;
            cr.TUpdate(value);
            return RedirectToAction("Index");
        }

    }
}
