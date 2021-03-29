using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShowDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowDemo.Controllers
{
    public class RatingController : Controller
    {
        private MovieDbContext _dbContext;

        public RatingController (MovieDbContext context)
        {
            _dbContext = context;

        }

        public IActionResult Index()
        {
            var ratinglist = _dbContext.ratingModels.ToList();
            return View(ratinglist);
        }
        public IActionResult CreateRating()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRating(RatingModel myrating)
        {
            _dbContext.ratingModels.Add(myrating);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EditRating(int id)
        {
            var data = _dbContext.ratingModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditRating(RatingModel myrating)
        {
            _dbContext.Entry(myrating).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRating(int id)
        {
            var data = _dbContext.movieModels.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult DeleteRating(RatingModel myrating)
        {
            _dbContext.Remove(myrating).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
