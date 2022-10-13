using DataAccessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRestaurantApp.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<Class1> ProList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                productName = "Computer",
                stock = 150
            });
            cs.Add(new Class1()
            {
                productName = "Keyboard",
                stock = 10
            });
            cs.Add(new Class1()
            {
                productName = "Mause",
                stock = 110
            });
            return cs;
        }
        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2
                {
                    foodname = x.Name,
                    stock = x.Stock
                }).ToList();
            }
            return cs2;
        }
        public IActionResult Statistics()
        {
            Context c = new Context();
            var value1 = c.Foods.Count();
            ViewBag.v1 = value1;

            var value2 = c.Categories.Count();
            ViewBag.v2 = value2;

            var value3 = c.Foods.Where(x => x.CategoryId == 3).Count();
            ViewBag.v3 = value3;

            var foodid = c.Categories.Where(x => x.CategoryName == "Yiyecek").Select(y => y.CategoryId).FirstOrDefault();
            var value4 = c.Foods.Where(x => x.CategoryId == foodid).Count();
            ViewBag.v4 = value4;

            var value5 = c.Foods.Where(x => x.CategoryId == 1).Count();
            ViewBag.v5 = value5;

            var value6 = c.Foods.Sum(x => x.Stock);
            ViewBag.v6 = value6;

            var value7 = c.Foods.OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault(); //en çok olanı alır
            ViewBag.v7 = value7;

            var value8 = c.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault(); //en az olanı alır
            ViewBag.v8 = value8;

            var value9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.v9 = value9;

            var value10 = c.Categories.Where(x => x.CategoryName == "İçecek").Select(y => y.CategoryId).FirstOrDefault();
            var values10 = c.Foods.Where(y => y.CategoryId == value10).Sum(x => x.Stock);
            ViewBag.v10 = values10; //toplam içecek sayısı

            var value11 = c.Categories.Where(x => x.CategoryName == "Yiyecek").Select(y => y.CategoryId).FirstOrDefault();
            var values11 = c.Foods.Where(y => y.CategoryId == value11).Sum(x => x.Stock);
            ViewBag.v11 = values11;

            var value12 = c.Categories.Where(x => x.CategoryName == "Meyve").Select(y => y.CategoryId).FirstOrDefault();
            var values12 = c.Foods.Where(y => y.CategoryId == value12).Sum(x => x.Stock);
            ViewBag.v12 = values12;

            return View();
        }
    }
}
