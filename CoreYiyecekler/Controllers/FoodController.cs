using CoreYiyecekler.Data.Models;
using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreYiyecekler.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository();
        Context context = new Context();


        public IActionResult Index(int page = 1)
        {

            return View(foodRepository.TList("Category").ToPagedList(page, 3));
        }

        // ( (1,3) Paging sayfa 1'den başlar ve her sayfada 3 veri içerir.)

        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> CategoryList = (from x in context.Categories.ToList()

                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryID.ToString()
                                                 }).ToList();
            ViewBag.dropDownValues = CategoryList;
            return View();
        }

        [HttpPost]
        public IActionResult FoodAdd(AddItem addItem)
        {
            Food food = new Food();

            if (addItem.ImageURL != null)
            {

                var extension = Path.GetExtension(addItem.ImageURL.FileName);
                var imageName =  Guid.NewGuid() + extension;
                var location=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/resimler/",imageName); 
                var stream=new FileStream(location, FileMode.Create);   
                addItem.ImageURL.CopyTo(stream);
                food.ImageURL =imageName;


            }
            food.FoodName = addItem.FoodName;
            food.Description = addItem.Description;
            food.Price = addItem.Price;

            food.Stock = addItem.Stock;
            food.CategoryID = addItem.CategoryID;

            foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFood(int id)
        {

            foodRepository.TDelete(new Food { FoodId = id });
            return RedirectToAction("Index");

        }

        public IActionResult FoodGet(int id)
        {

            var x = foodRepository.TGet(id);
            Food food = new Food()
            {
                FoodId = x.FoodId,
                CategoryID = x.CategoryID,
                FoodName = x.FoodName,
                Price = x.Price,
                Description = x.Description,
                ImageURL = x.ImageURL,
                Stock = x.Stock,

            };


            return View(food);

        }

        [HttpPost]
        public IActionResult FoodUpdate(Food food)
        {

            var x = foodRepository.TGet(food.FoodId);
            x.FoodName = food.FoodName;
            x.Description = food.Description;
            x.Price = food.Price;
            x.Stock = food.Stock;
            x.Price = food.Price;
            x.ImageURL = food.ImageURL;
            x.CategoryID = food.CategoryID;


            foodRepository.TUpdate(x);
            return RedirectToAction("Index");

        }

    }
}
