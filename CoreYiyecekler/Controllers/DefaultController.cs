using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreYiyecekler.Controllers
{
    public class DefaultController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult CategoryDetails()
        {

            return View();

        }
    }
}
