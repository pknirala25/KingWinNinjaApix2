using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShowDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowDemo.Controllers
{
    public class TheatreController : Controller
    {
       private MovieDbContext _dbContext;

        public TheatreController(MovieDbContext context)
        {
            _dbContext = context;
        }


        public IActionResult Index()
        {
           var theatrelist = _dbContext.theatreModels.ToList();
            return View(theatrelist);
        }
        public IActionResult CreateTheatre()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateTheatre(TheatreModel mytheatre)
        {
            _dbContext.theatreModels.Add(mytheatre);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EditTheatre(int id)
        {
            var data = _dbContext.theatreModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditTheatre(TheatreModel mytheatre)
        {
            _dbContext.Entry(mytheatre).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return View();
        }


        public IActionResult DeleteTheatre(int id)
        {
            var data = _dbContext.theatreModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult DeleteTheatre(TheatreModel mytheatre)
        {
            _dbContext.Remove(mytheatre).State = EntityState.Deleted;
            _dbContext.SaveChanges();

            return View();
        }
    }
}
