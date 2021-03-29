using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowDemo.Models
{
    public class MovieModel
    {
        [Required]
        public string MovieName { get; set; }

        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required (ErrorMessage ="Provide Ur Preferred Language")]
        public string Language { get; set; }

        [Required (ErrorMessage ="Please Enter the type of Movie")]
        public string Type { get; set; }




    }
}
