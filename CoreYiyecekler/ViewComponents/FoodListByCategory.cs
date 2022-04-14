using CoreYiyecekler.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreYiyecekler.ViewComponents
{
    public class FoodListByCategory : ViewComponent
    {

        public IViewComponentResult Invoke(int id)
        {
            // category detailstan aldigin degiskenin ismiyle ayni olmasi lazim id olarak yazmalisin
            
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.List(x=> x.CategoryID== id);
            return View(foodList);

        }
    }
}
