using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyProject.Models;

namespace UdemyProject.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movies = new Movies()
            {
                Name = "Ella"
            };
            return View(movies);
        }
    }
}
