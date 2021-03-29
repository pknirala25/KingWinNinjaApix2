using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShowDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowDemo.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbContext _dbContext;

        public MovieController (MovieDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            var movielist = _dbContext.movieModels.ToList();
            return View(movielist);
        }

        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(MovieModel mymovie)
        {
            _dbContext.movieModels.Add(mymovie);
            _dbContext.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public IActionResult EditMovie(int id)
        {
            var data = _dbContext.movieModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditMovie(MovieModel mymovie)
        {
            _dbContext.Entry(mymovie).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMovie(int id)
        {
            var data = _dbContext.movieModels.Find(id);
            return View(data);

        }
        [HttpPost]
        public IActionResult DeleteMovie(MovieModel mymovie)
        {
            _dbContext.Remove(mymovie).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
