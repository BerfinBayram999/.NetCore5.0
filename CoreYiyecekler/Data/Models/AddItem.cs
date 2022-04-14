using Microsoft.AspNetCore.Http;

namespace CoreYiyecekler.Data.Models
{
	public class AddItem
	{

        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile ImageURL { get; set; }
        public int Stock { get; set; }
        public int? CategoryID { get; set; }
    }
}
