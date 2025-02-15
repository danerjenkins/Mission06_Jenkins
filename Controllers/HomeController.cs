using System.Diagnostics;
using JoelMovieCollection.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoelMovieCollection.Controllers
{
    
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutJoel()
        {
            return View();
        }
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);// add record to database
            _context.SaveChanges();
            return View("Confirmation", movie);
        }
    }
}
