using DataAccessLayer.Concrete;
using DataAccessLayer.Entity;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace WebRestaurantApp.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository fr = new FoodRepository();
        Context c = new Context();
        public IActionResult Index(int page = 1)
        {
            return View(fr.TList("Category").ToPagedList(page, 5));
        }
        public IActionResult DeleteFood(int id)
        {
            fr.TDelete(new Food { FoodId = id });
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> value = (from x in c.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryId.ToString()
                                          }).ToList();
            ViewBag.v1 = value;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(urunekle p)
        {
            Food f = new Food();
            if (p.ImageUrl!=null)
            {
                var extension = Path.GetExtension(p.ImageUrl.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/",newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                f.ImageUrl = newimagename;
            }
            f.Name = p.Name;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryId = p.CategoryId;
            f.Description = p.Description;


            fr.TAdd(f);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateFood(int id)
        {
            List<SelectListItem> val = (from x in c.Categories.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoryName,
                                            Value = x.CategoryId.ToString()
                                        }).ToList();
            ViewBag.v1 = val;
            var value = fr.TGet(id);
            Food food = new Food
            {
                FoodId = value.FoodId,
                CategoryId = value.CategoryId,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                Description = value.Description,
                ImageUrl = value.ImageUrl
            };
            return View(food);
        }
        [HttpPost]
        public IActionResult UpdateFood(Food p)
        {
            var value = fr.TGet(p.FoodId);
            value.Name = p.Name;
            value.Stock = p.Stock;
            value.Price = p.Price;
            value.ImageUrl = p.ImageUrl;
            value.Description = p.Description;
            value.CategoryId = p.CategoryId;
            fr.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
