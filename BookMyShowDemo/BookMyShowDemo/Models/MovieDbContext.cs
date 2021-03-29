using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowDemo.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options): base (options)
        {

        }
        public DbSet<LocationModel> locationModels { get; set; }
        public DbSet<TheatreModel> theatreModels { get; set; }

        public DbSet<MovieModel> movieModels { get; set; }

        public DbSet<RatingModel> ratingModels { get; set; }

    }
}
