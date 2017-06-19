using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);         
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("Search!");
        }

        //return Json(new { Message = message, Name = "Ben" }, JsonRequestBehavior.AllowGet);

        //return File(Server.MapPath("~/Content/site.css"), "text/css");

        //return RedirectToRoute("Default", new { controller = "Home", action = "About" });

        //return RedirectToAction("Index", "Home", new { name = name });
    }
}