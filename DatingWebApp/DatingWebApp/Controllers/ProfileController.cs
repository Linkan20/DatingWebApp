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
                    var fileType = Path.GetExtension(image.FileName).ToLower();

                    string fileName = User.Identity.GetUserId();
                    string path = Path.Combine(Server.MapPath("~/Images/" + fileName + fileType));
                    model.Image = fileName + fileType;
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
            var ctx = new DatingDbContext();
            string userID = User.Identity.GetUserId();

            ProfileModel profile = ctx.Profiles.FirstOrDefault(p => p.User_ID.Equals(userID));

            return View(profile);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(ProfileModel model, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                var ctx = new DatingDbContext();
                string userID = User.Identity.GetUserId();       

                ProfileModel profile = ctx.Profiles.FirstOrDefault(p => p.User_ID.Equals(userID));

                profile.User_ID = model.User_ID;
                profile.Firstname = model.Firstname;
                profile.Lastname = model.Lastname;
                profile.Birthdate = model.Birthdate;
                profile.City = model.City;
                profile.Biography = model.Biography;
                profile.Gender = model.Gender;
                profile.LookingFor = model.LookingFor;

                if (image != null) //egen metod?
                {              
                    var prevFileName = Path.GetFileNameWithoutExtension(profile.Image);
                    
                    if (prevFileName.Equals(userID))
                    {
                        var prevPath = Path.Combine(Server.MapPath("~/Images/" + profile.Image));
                        System.IO.File.Delete(prevPath);
                    }

                    var fileType = Path.GetExtension(image.FileName).ToLower();
                    string path = Path.Combine(Server.MapPath("~/Images/" + userID + fileType));
                    profile.Image = userID + fileType;
                    image.SaveAs(path);
                }

                ctx.SaveChanges();

                return RedirectToAction("EditProfile", "Profile");
            }
            return View(model);
        }
    }
}