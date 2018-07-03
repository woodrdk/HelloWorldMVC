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
            return View();
            // Response.Write("Welcome to the index!"); // example code to explain the controllers
        }

        public void Rob()
        {
            Response.Write("BREAK TIME");
        }
    }
}