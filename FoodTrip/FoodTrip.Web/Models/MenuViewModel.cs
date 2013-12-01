using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodTrip.Web.Models
{
    public class MenuViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        public IList<MenuItem> MenuItems { get; set; } 
    }
}