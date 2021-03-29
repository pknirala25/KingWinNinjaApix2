 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShowDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowDemo.Controllers
{
    public class LocationController : Controller
    {
        private MovieDbContext _dbContext;

        public LocationController(MovieDbContext context) 
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            var locationlist = _dbContext.locationModels.ToList();

            return View(locationlist);
        }
        public IActionResult CreateLocation()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateLocation(LocationModel mylocation)
        {
            _dbContext.locationModels.Add(mylocation);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult EditLocation(int id)
        {
            var data = _dbContext.locationModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditLocation(LocationModel mylocation)
        {
            _dbContext.Entry(mylocation).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteLocation(int id)
        {
            var data = _dbContext.locationModels.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult DeleteLocation(LocationModel mylocation)
        {
            _dbContext.Remove(mylocation).State = EntityState.Deleted;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
