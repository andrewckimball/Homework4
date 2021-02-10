using AndrewHomework4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Controller for index page
        public IActionResult Index()
        {
            //Instantiating the class
            List<string> restaurantList;

            restaurantList = new List<string>();

            //For loop to go through each object
            foreach(Restaurants r in Restaurants.GetRestaurants())
            {
                //"It's all tasty!" displayed in place 'Fav Dish = null'
                string dish = r.FavDish ?? "It's all tasty!";

                //Concatinating the output that will be shown on the index.cshtml page
                restaurantList.Add(string.Format(r.Rank + ":  " + r.Name + "  |  " + dish + "  |  " + r.Address +
                    "  |  "  + r.Phone + "  |   " + r.WebLink));
            }

            return View(restaurantList);
        }

        //HttpGet controller
        [HttpGet]
        public IActionResult RestaurantInput()
        {
            return View();
        }


        //HttpPost controller for the submission of the RestuarantInput view
        [HttpPost]
        public IActionResult RestaurantInput(RestaurantSubmit appResponse)
        {
            //If the  user inputs the data correctly, output the following...
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(appResponse);
                //return RedirectToAction("Results");   //Returning the Results view
                return View("Confirmation", appResponse);
            }

            return View();
        }

        //Results controller for Results.cshtml
        public IActionResult Results()
        {
            return View(TempStorage.Applications);
        } 

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
