using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        
    }
}