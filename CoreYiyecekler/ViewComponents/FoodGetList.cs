using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreYiyecekler.ViewComponents
{
    public class FoodGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.TList();
            return View(foodList);

        }
    }
}
