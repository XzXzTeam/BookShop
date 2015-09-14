using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new DatabaseContext())
            {
                db.Images.Select(image => image.Id == 1);
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            using (var db = new DatabaseContext())
            {
                db.Images.Add(new Model.Image { RelativePath = "Fuck you.!!!" });
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}