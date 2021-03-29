using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowDemo.Models
{
    public class TheatreModel
    {
        [Key]
        [Required]
        public int TheatreId { get; set; }

        [Required]
        public string Theatre { get; set; }

    }
}
