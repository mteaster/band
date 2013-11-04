<<<<<<< HEAD
﻿using System.Web.Mvc;
using band.Models;
using band.Stuff;
using WebMatrix.WebData;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39

namespace band.Controllers
{
    public class OnlineController : Controller
    {
        //
        // GET: /Online/

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

=======
        public ActionResult Index()
        {
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39
            return View();
        }

    }
}
