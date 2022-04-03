using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Data.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public int Stock { get; set; }
        public virtual Category Category { get; set; }
    }
}
