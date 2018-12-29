using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DatingWebApp.Models;

namespace DatingWebApp.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            var ctx = new DatingDbContext();
            var viewModel = new ProfileIndexViewModel
            {
                Profiles = ctx.Profiles.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProfile(Profile model, HttpPostedFileBase image)
        {
            var ctx = new DatingDbContext();

            if (image != null)
            {
                model.Image = image.FileName;
                string fileName = Path.GetFileName(image.FileName);
                string path = Path.Combine(Server.MapPath("~/Images/"
                + fileName));
                image.SaveAs(path);
            }

            ctx.Profiles.Add(model);
            ctx.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}