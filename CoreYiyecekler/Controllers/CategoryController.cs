using CoreYiyecekler.Data.Models;
using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index()
        {

            
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

            if(!ModelState.IsValid)
            {

                return View("CategoryAdd");
            }



            categoryRepository.TAdd(category);
            return RedirectToAction("Index"); 
        }


        public IActionResult CategoryGet(int id)
        {
            var x= categoryRepository.TGet(id);
            return View();



        }
    }
}
