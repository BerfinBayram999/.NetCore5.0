using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {

            FoodRepository foodRepository = new FoodRepository();
            return View(foodRepository.TList());
        }
    }
}
