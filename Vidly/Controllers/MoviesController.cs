using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Id=1, Title = "DDLJ"},
                new Movie { Id=2, Title = "Dangal"},
                new Movie { Id=3, Title = "PK"}
            };

            var movieView = new MoviesViewModel
            {
                Movies = movies
            };
            return View(movieView);
        }
    }
}

//@Scripts.Render("~/bundles/bootstrap")