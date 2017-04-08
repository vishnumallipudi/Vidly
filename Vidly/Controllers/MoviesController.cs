using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {

            var movies = GetMoives();

           
            return View(movies);
        }
        public IEnumerable<Movie> GetMoives()
        {
            return  new List<Movie>
            {
                new Movie { Name="Shrek!"},
                new Movie {Name="Wall-e" }
            };
        }
        
       
    }
}