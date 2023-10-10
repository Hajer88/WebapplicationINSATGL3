using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebapplicationINSATGL3.Models;

namespace WebapplicationINSATGL3.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationdbContext _db;
        public MovieController(ApplicationdbContext _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {
            var movies = _db.movies.ToList();
            return View(movies);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return Content("unable to find Id");
            var c = _db.movies.SingleOrDefault(c => c.Id == id);
            return View(c);
        }
        public IEnumerable<Movie> GetListOfMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
            new Movie{Id = 1, Name ="Test"},
            new Movie{Id = 2, Name ="Test2"},
            };
            return movies;
        }

        
        

    }
}
