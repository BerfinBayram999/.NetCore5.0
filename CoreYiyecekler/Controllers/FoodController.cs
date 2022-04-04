using CoreYiyecekler.Data.Models;
using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context context=new Context();

        public IActionResult Index()
        {

          
            //return View(foodRepository.TList());
            return View(foodRepository.TList("Category"));
        }

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> CategoryList = (from x in context.Categories.ToList()

                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value=x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.dropDownValues = CategoryList;
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(Food food)
        {
          
            foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFood(int id)
        {

            foodRepository.TDelete(new Food { FoodId=id}); 
            return RedirectToAction("Index");

        }



    }
}
