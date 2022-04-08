using CoreYiyecekler.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreYiyecekler.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        

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






    }
}
