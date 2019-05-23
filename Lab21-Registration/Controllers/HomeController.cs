using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21_Registration.Models;

namespace Lab21_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Thank you for wanting to join our Coffee Club";

            return View();
        }

        public ActionResult Welcome(NewUser newUser)
        {
            ViewBag.UserName = newUser.UserName;

            return View();
        }
    }
}