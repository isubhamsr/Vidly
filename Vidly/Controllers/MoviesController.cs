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
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new Movie() { Id = 1, Title="DDLJ" };
            return View(movies);
        }
    }
}

//@Scripts.Render("~/bundles/bootstrap")