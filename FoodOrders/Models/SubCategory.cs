using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrders.Models
{
    public class SubCategory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Sub category")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }


    }
}
