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
        // GET: Movies/Ramdom
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Itachi Uchiha!" };
            //return View(movie);
            //return HttpNotFound();
            //return Content("Hello world!");
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page=1, sortBy="name" });
        }
    }
}