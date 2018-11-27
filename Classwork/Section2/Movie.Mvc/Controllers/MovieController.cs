﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie.Mvc.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet]       // this is a verb
        public ActionResult Index()
        {
            return View();
            //return View("Index");     // same as above code       // will look in views folder 
        }
    }
}