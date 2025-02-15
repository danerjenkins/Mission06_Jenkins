using System.Diagnostics;
using JoelMovieCollection.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoelMovieCollection.Controllers
{
    
    public class HomeController : Controller
    {
        private MoviesContext _context;
        // create a context variale that will be used to access the database
        public HomeController(MoviesContext context)
        {
            //upon starting the program set the  database variable using the connection string
            _context = context;
        }
        //show the individual views
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
        // route/methode to add a movie to the database
        // the method will be called when the form is submitted
        public IActionResult AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);// add record to database
            _context.SaveChanges();
            return View("Confirmation", movie);
        }
    }
}
