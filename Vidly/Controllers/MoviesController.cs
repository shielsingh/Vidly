using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        IList<Movie> Movies = new List<Movie>();

        public MoviesController()
        {
            Movies.Add(new Movie { Id = 1, Name = "Shrek!!!" });
            Movies.Add(new Movie { Id = 2, Name = "Transformers!!!" });
        }

        // GET: Movies
        public ActionResult Index()
        {
            return View(Movies);
        }
    }
}