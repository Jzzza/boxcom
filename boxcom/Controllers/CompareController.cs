using boxcom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace boxcom.Controllers
{
    public class CompareController : Controller
    {
        // GET: Compare
        public ActionResult Select()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View(new List<Boxer>() { new Boxer().getBoxer(Request.Form["b1"]), new Boxer().getBoxer(Request.Form["b2"]) });
        }

        public ActionResult Catalog()
        {
            return View();
        }
    }
}