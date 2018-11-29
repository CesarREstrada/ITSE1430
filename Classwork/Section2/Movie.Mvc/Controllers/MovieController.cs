using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Itse1430.MovieLib;
using Itse1430MovieLib.SQL;
using Movie.Mvc.Models;

namespace Movie.Mvc.Controllers
{
    public class MovieController : Controller
    {
        public MovieController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];       // going into the config file looking for the connection string 

            _database = new SqlMovieDatebase(connString.ConnectionString);
        }


        [HttpGet]       // this is a verb
        public ActionResult Index () 
        {
            var items = _database.GetAll();         // returns all of the movies
            
            return View(items.Select(i => new MovieModel(i)));    
            //return View("Index");     // same as above code       // will look in views folder 
        }

        [HttpGet]
        public ActionResult Create ()
        {
            var model = new MovieModel();

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit( int id )
        {
            var item = _database.GetAll().FirstOrDefault(i => i.Id == id);

            return View(new MovieModel(item));
        }

        [HttpPost]
        public ActionResult Create ( MovieModel model )
        {
            if (ModelState.IsValid)         // validates on the URL side
            {
                try
                {
                    var item = model.ToDomain();

                    _database.Add(item);

                    return RedirectToAction("Index");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit( MovieModel model )
        {
            if (ModelState.IsValid)         // validates on the URL side
            {
                try
                {
                    var item = model.ToDomain();

                    var existing = _database.GetAll().FirstOrDefault(i => i.Id == model.Id);        // you may be able to use this for PA4
                    _database.Edit(existing.Name, item);

                    return RedirectToAction("Index");
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            };

            return View(model);
        }

        private readonly IMovieDatabase _database;
    }
}