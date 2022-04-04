using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Data.Models
{
    public class Category
    {

  
        public int CategoryID { get; set; }


        [Required(ErrorMessage = "CategoryName can not be empty!")]
        [StringLength(20,ErrorMessage ="CategoryName  only can be 20 characters!"),MinLength(4,ErrorMessage = "CategoryName can be min 4 characters!")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool Status { get; set; }
        public List<Food> Foods { get; set; }

    }
}
