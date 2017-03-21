using OdeToFood.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        [HttpGet]
        public ActionResult Search(string name = "*")
        {
            throw new Exception("oops");
            //if (name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            //    //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //    //return RedirectToRoute("Cuisine", new { name = "german" });
            //    //return RedirectToAction("Search", "Cuisine", new { name = "french" });
            //}

            name = Server.HtmlEncode(name);
            //return RedirectToAction("Index", "Home");
            return Content(name);
        }
    }
}