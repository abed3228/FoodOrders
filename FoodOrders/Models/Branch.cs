using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrders.Models
{
    public class Branch
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name branch")]
        public string NameBranch { get; set; }

        [Required]
        [Display(Name = "City branch")]
        public string CityBranch { get; set; }

        [Required]
        [Display(Name = "Street branch")]
        public string StreetBranch { get; set; }

        [Required]
        [Display(Name = "Street number branch")]
        public string StreetNumberBranch { get; set; }

        [Required]
        [Display(Name = "Phone number branch")]
        public string PhoneNumberBranch { get; set; }

        [Required]
        [Display(Name = "Opening hours branch")]
        public string OpeningHoursBranch { get; set; }

        [Required]
        [Display(Name = "Map - Latitude")]
        public double nLatitude { get; set; }

        [Required]
        [Display(Name = "Map - Longitude")]
        public double nLongitude { get; set; }

        public string remark { get; set; }
    }
}
