using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrders.Models.SubCategoryViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        public SubCategory SubCategory { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }

        public List<String> SubCategoryList { get; set; }

        [Display(Name = "New sub category")]
        public bool IsNew { get; set; }

        public string StatusMessage { get; set; }

    }
}
