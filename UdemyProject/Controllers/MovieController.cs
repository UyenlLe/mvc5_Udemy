using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyProject.Models;
using UdemyProject.ViewModels;

namespace UdemyProject.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movies = new Movie()
            {
                Name = "Ella"
            };
            return View(movies);
        }

        public ActionResult RandomHttpNotFound()
        {
            return HttpNotFound();
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("Page index = {0}, Sort by = {1}", pageIndex.ToString(), sortBy));
        }

        public ActionResult MoviesReleased(int month, int year)
        {
            return Content(String.Format("Month: {0}, Year: {1}", month, year));
        }

        [Route("movies/released2/{year}/{month}")]

        public ActionResult MoviesReleased2 (int month, int year)
        {
            return Content(String.Format("Month: {0}, Year: {1}", month, year));
        }

        [Route("movie/randommovie")]
        public ActionResult RandomMovies()
        {
            var movie = new Movie()
            {
                Name = "Yeu em bat chap"
            };

            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Bao Uyen"
                },
                new Customer()
                {
                    Name = "Bao Quyen"
                }
            };

            var randomMovies = new RandomMovieViewModel()
            {
                Movie = movie,
                Customer = customers
            };

            return View(randomMovies);
        }
    }
}
