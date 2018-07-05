using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DayOfWeek day = DateTime.Today.DayOfWeek;
            if (day == DayOfWeek.Thursday)
            {
                // viewbag is a wrapper around ViewData
                ViewBag.Message = "It's Thursday!";
                // same as above
                ViewData["Message"] = "It's Thursday!";

            }
            else {
                ViewBag.Message = "Not Thursday!";
            }
            // data inside viewbag or ViewData is auto sent to the view

            return View();
            // Response.Write("Welcome to the index!"); // example code to explain the controllers
        }

        public ActionResult Contact()
        {
            return View();
            // will return the contact page
        }

        public void Rob()
        {
            Response.Write("BREAK TIME");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}