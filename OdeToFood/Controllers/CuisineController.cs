﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "*")
        {
            name = Server.HtmlEncode(name);
            return Content(name);
        }
    }
}