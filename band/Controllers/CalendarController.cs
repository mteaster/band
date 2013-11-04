using System;
<<<<<<< HEAD
using System.Web.Mvc;
using band.Models;
using band.Stuff;
using WebMatrix.WebData;
=======
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39

namespace band.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/

<<<<<<< HEAD
        public ActionResult Index(int bandId)
        {
            // Check if band exists - if it does, get band profile
            BandProfile bandProfile = BandUtil.BandProfileFor(bandId);

            ViewBag.BandId = bandId;
            ViewBag.BandName = bandProfile.BandName;

            // Check if the user is in the band
            if (!BandUtil.IsUserInBand(WebSecurity.CurrentUserId, bandId))
            {
                return RedirectToAction("Join", "Band");
            }

            return View();
        }

        //
        // GET: /Calendar/AddEvent

        public ActionResult AddEvent(int bandId)
        {
            // Check if band exists - if it does, get band profile
            BandProfile bandProfile = BandUtil.BandProfileFor(bandId);

            ViewBag.BandId = bandId;
            ViewBag.BandName = bandProfile.BandName;

            // Check if the user is in the band
            if (!BandUtil.IsUserInBand(WebSecurity.CurrentUserId, bandId))
            {
                return RedirectToAction("Join", "Band");
            }

            return View();
        }

        //
        // Post: /Calendar/AddEvent

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEvent(int bandId, CalendarEventModel model)
        {
            // Check if band exists - if it does, get band profile
            BandProfile bandProfile = BandUtil.BandProfileFor(bandId);

            ViewBag.BandId = bandId;
            ViewBag.BandName = bandProfile.BandName;

            // Check if the user is in the band
            if (!BandUtil.IsUserInBand(WebSecurity.CurrentUserId, bandId))
            {
                return RedirectToAction("Join", "Band");
            }

            if (ModelState.IsValid)
            {
                CalendarEvent calendarEvent = new CalendarEvent();

                calendarEvent.BandId = bandId;
                calendarEvent.EventTitle = model.EventTitle;    
                calendarEvent.EventTime = new DateTime(model.EventYear, model.EventMonth, model.EventDay);
                calendarEvent.EventDescription = model.EventDescription;

                using (DatabaseContext database = new DatabaseContext())
                {
                    database.CalendarEvents.Add(calendarEvent);
                    database.SaveChanges();
                }

                ViewBag.StatusMessage = "we added a calendar event and nothing broke";
                return View("Success");
            }

            return View(model);
        }
=======
        public ActionResult Index()
        {
            return View();
        }

>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39
    }
}
