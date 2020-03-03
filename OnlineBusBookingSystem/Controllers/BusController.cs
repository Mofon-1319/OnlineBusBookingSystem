using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBusBookingSystem.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Manage_Bus()
        {
            return View();
        }

        public ActionResult Book()
        {
            return View();
        }
    }
}