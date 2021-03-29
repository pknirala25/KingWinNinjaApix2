using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShowDemo.Models
{
    public class RatingModel
    {
        [Key]
        public int RatingId { get; set; }

 [Required(ErrorMessage ="Please provide rating")]
        public int RatingNumber { get; set; }


        [ForeignKey("MovieId")]
        public int MovieId { get; set; }


        [Required(ErrorMessage = "Please write something about the movie")]

        public string RatingComment { get; set; }

        //public string MovieName { get; set; }



       

        public MovieModel movieModels { get; set; }
    }
}
