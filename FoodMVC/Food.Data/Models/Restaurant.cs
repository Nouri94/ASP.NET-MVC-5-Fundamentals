using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(225)]
        public string Name { get; set; }

        [Display(Name="Type of Food")]
        public CuisineType Cuisine { get; set; }

    }
}
