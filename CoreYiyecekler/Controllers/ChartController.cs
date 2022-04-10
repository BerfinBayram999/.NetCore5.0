using CoreYiyecekler.Data;
using CoreYiyecekler.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreYiyecekler.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        //Ürün Sonuçlarını Görselleştir
        public IActionResult VisualizeProductResult()
        {
            return Json(ProList());
        }

        public List<Class> ProList()
        {


            List<Class> cs = new List<Class>();
            cs.Add(new Class()
            {

                ProductName = "Computer",
                Stock = 150


            });
            cs.Add(new Class()
            {
                ProductName = "Lcd",
                Stock = 250


            });
            cs.Add(new Class()
            {
                ProductName = "USB Disk",
                Stock = 230


            });
            return cs;
        }


        public IActionResult Index2()
        {



            return View();
        }
        public IActionResult Index3()
        {



            return View();
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }

        public List<Class2> FoodList()
        {

            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2

                {

                    FoodName = x.FoodName,
                    Stock = x.Stock
                }).ToList();
            }
            return cs2;
        }


        public IActionResult Statistics()
        {
            Context c = new Context();
            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            var foid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            ViewBag.d = foid;
            var deger3 = c.Foods.Where(x => x.CategoryID == foid).Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryID).FirstOrDefault()).Count();
            ViewBag.d4 = deger4;

            var deger5 = c.Foods.Sum(x => x.Stock);
            ViewBag.d5 = deger5;

            var deger6 = c.Foods.Where(x => x.CategoryID == c.Categories.Where(y => y.CategoryName == "Legumes").Select(z => z.CategoryID).FirstOrDefault()).Count();
            ViewBag.d6 = deger6;

            var deger7 = c.Foods.OrderByDescending(X => X.Stock).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.Foods.OrderBy(X => X.Stock).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = c.Foods.Average(X => X.Price).ToString("0.00");
            ViewBag.d9 = deger9;

            var deger10 = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            var deger10p = c.Foods.Where(y => y.CategoryID == deger10).Sum(x => x.Stock);
            ViewBag.d10 = deger10p;

            var deger11 = c.Categories.Where(x => x.CategoryName == "Vegatables").Select(y => y.CategoryID).FirstOrDefault();
            var deger11p = c.Foods.Where(y => y.CategoryID == deger11).Sum(x => x.Stock);
            ViewBag.d11 = deger11p;

            var deger12 = c.Foods.OrderByDescending(x => x.Price).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d12 = deger12;
            return View();

        }
    }
}
