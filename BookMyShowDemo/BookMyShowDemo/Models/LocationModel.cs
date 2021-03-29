using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowDemo.Models
{
    public class LocationModel
    {
        [Key]
        [Required (ErrorMessage = "LocationId cannot be empty")]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Location cannot be empty")]
        public string Location { get; set; }
    }
}
