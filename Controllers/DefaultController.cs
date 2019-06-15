using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Raising_hands.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ABOUTUS()
        {
            return View();
        }
        public ActionResult ACTIVITIES()
        {
            return View();
        }
        public ActionResult GALLERY()
        {
            return View();
        }
        public ActionResult FOUNDERS()
        {
            return View();
        }
        public ActionResult DONATIONS()
        {
            return View();
        }
    }
}