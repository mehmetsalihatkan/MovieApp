using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System.Linq;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            if (id!=null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
        
    }
}