﻿using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {

            CategoryRepository categoryRepository = new CategoryRepository();
            return View(categoryRepository.TList());
        }
    }
}
