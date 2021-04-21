using lab6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            return View(db.Cars.ToList());
        }

        public IActionResult SearchByModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByModel(Car car)
        {
            Car car1 = db.Cars.FirstOrDefault(c => c.Model == car.Model);
            return View(car1);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car car)
        {
            db.Cars.Add(new Car { Model = car.Model, Price = car.Price });
            db.SaveChanges();
            return View();
        }

        public IActionResult SearchByPrice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByPrice(CarManager carManager)
        {
            carManager.Cars = db.Cars.Where(c => c.Price <= carManager.Price).ToList();
            return View(carManager);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
