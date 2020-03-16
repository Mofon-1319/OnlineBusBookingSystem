using OnlineBusBookingSystem.DAL;
using OnlineBusBookingSystem.Entity;
using OnlineBusBookingSystem.Models;
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
        BusRepository busRepository = new BusRepository();
        IEnumerable<Bus> busList;
        public ActionResult Manage_Bus()
        {
            busList = busRepository.GetBus();
            return View(busList);
        }

        [HttpGet]
        public ActionResult Add_Bus()
        {
            IEnumerable<Bus> bus = busRepository.CreateDB();
            //ViewBag.Bus = new SelectList(busRepository.GetBus(), "BusId", "BusNo");
            return View();
        }
        [HttpPost]
        public ActionResult Add_Bus(BusModel busModel)
        {
            Bus bus = new Bus();
            ViewBag.Bus = new SelectList(busRepository.GetBus(), "BusId", "BusNo");
            bus.BusId = busModel.BusId;
            bus.BusNo = busModel.BusNo;
            bus.TotalSeat = busModel.TotalSeat;
            bus.Rate = busModel.Rate;
            busRepository.AddBus(bus);
            return View();
        }


        public ActionResult Book()
        {
            return View();
        }
    }
}