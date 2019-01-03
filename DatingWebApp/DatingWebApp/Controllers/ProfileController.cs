using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

using DatingWebApp.Models;

namespace DatingWebApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public ActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile(ProfileModel model, HttpPostedFileBase image)
        {
            if(ModelState.IsValid)
            {
                var ctx = new DatingDbContext();

                if (image != null)
                {
                    var type = Path.GetExtension(image.FileName).ToLower();

                    string fileName = User.Identity.GetUserId();
                    string path = Path.Combine(Server.MapPath("~/Images/" + fileName + type));
                    model.Image = fileName + type;
                    image.SaveAs(path);
                }
                model.User_ID = User.Identity.GetUserId();

                ctx.Profiles.Add(model);
                ctx.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public ActionResult EditProfile()
        {
            return View();
        }
    }
}