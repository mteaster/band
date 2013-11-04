<<<<<<< HEAD
﻿using System.Web.Mvc;
using System.Web.Security;
using band.Models;
using band.Stuff;
using WebMatrix.WebData;

namespace band.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public ActionResult DeletePost(int postId)
        {
            if (MessageBoardUtil.DeletePost(postId))
            {
                TempData["SuccessMessage"] = "Post deleted!";
            }
            else
            {
                TempData["ErrorMessage"] = "You cannot delete someone else's post!";
            }

            return RedirectToLocal(Request.UrlReferrer.AbsolutePath);
        }

        [HttpPost]
        public ActionResult EditPost(int postId, PostMessageModel model)
        {
            if (MessageBoardUtil.EditPost(postId, model.Content))
            {
                TempData["SuccessMessage"] = "Post edited!";
            }
            else
            {
                TempData["ErrorMessage"] = "You cannot edit someone else's post!";
            }

            return RedirectToLocal(Request.UrlReferrer.AbsolutePath);
        }

        public ActionResult EditPost(int postId)
        {
            ViewBag.PostId = postId;
            return View();
        }

        public ActionResult Index(int bandId)
        {
            // Check if band exists - if it does, get band profile
            BandProfile bandProfile = BandUtil.BandProfileFor(bandId);

            DashboardViewModel dvm = new DashboardViewModel();

            ViewBag.BandId = bandId;
            ViewBag.BandName = bandProfile.BandName;

            // Check if the user is in the band
            if (!BandUtil.IsUserInBand(WebSecurity.CurrentUserId, bandId) && !Roles.IsUserInRole("Administrator"))
            {
                return RedirectToAction("Join", "Band");
            }

            ViewBag.SuccessMessage = TempData["SuccessMessage"];
            ViewBag.ErrorMessage = TempData["ErrorMessage"];

            dvm.DisplayMessagesModel = MessageBoardUtil.PostsFor(bandId);
            
            return View(dvm);
        }

        [HttpPost]
        public ActionResult Index(int bandId, PostMessageModel model)
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

            DashboardViewModel dvm = new DashboardViewModel();
            dvm.PostMessageModel = model;

            if (ModelState.IsValid)
            {
                MessageBoardUtil.AddPost(bandId, model.Content);
                ViewBag.SuccessMessage = "Message posted!";
            }
            else
            {
                ViewBag.ErrorMessage = "We don't like empty messages.";
            }

            dvm.DisplayMessagesModel = MessageBoardUtil.PostsFor(bandId);

            return View(dvm);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }    
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace band.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            ViewBag.Message = getMsg();
            return View();
        }

        public String getMsg()
        {
            return "Code will go here to query DB for messages";
        }



    }
>>>>>>> dd962774445a69b12a838f55de74fe554db5ac39
}
