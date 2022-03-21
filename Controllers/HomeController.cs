using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }
        public IActionResult Contact()
        {
            return View();
        }
        
    }
}