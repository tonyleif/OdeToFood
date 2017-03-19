﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //ViewBag.Message = "Welcome to ASP.NET";
            ViewBag.Message = string.Format("{0}::{1} {2}",
                RouteData.Values["controller"],
                RouteData.Values["action"],
                RouteData.Values["id"]);
            var model = new RestaurantReview()
            {
                Name = "Tersiguel's",
                Rating = 9
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Location = "Maryland, USA";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}