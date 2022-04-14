using CoreYiyecekler.Data.Models;
using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;


namespace CoreYiyecekler.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();


        public IActionResult Index(string p)
        {
			if (!string.IsNullOrEmpty(p))
			{
                return View(categoryRepository.List(x=>x.CategoryName==p));




			}
            return View(categoryRepository.TList());
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



            categoryRepository.TAdd(category);
            return RedirectToAction("Index");
        }


        public IActionResult CategoryGet(int id)
        {
            var x = categoryRepository.TGet(id);

            Category ct = new Category();

            ct.CategoryName = x.CategoryName;
            ct.CategoryDescription = x.CategoryDescription;
            ct.CategoryID = x.CategoryID;
            

            return View(ct);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {

            var x = categoryRepository.TGet(category.CategoryID);
            x.CategoryName = category.CategoryName;
            x.CategoryDescription = category.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");

        }

        public IActionResult CategoryDelete(int id)
        {

            var x=categoryRepository.TGet(id);
            x.Status = false;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");


        }
    }
}

