using HelloWorldMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class StudentController : Controller
    {
        // when user navigates to a URL
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // this will get called after a user submits an html form
        // aka after they post data to the server
        [HttpPost]
        public ActionResult Index(FormCollection studentData)
        {
            // validate all form data

            // encapsulate form data in an object
                // HelloWorldMVC.Models.Student     or following
                // Models.Student stu = new Models.Student();  or the  following 
                // with "using HelloWorldMVC.Models;"
            Student stu = new Student
            {
                StudentId = studentData["sid"],
                FirstName = studentData["fName"],
                LastName = studentData["lName"],
                DateOfBirth = Convert.ToDateTime(studentData["dob"])
            };


            // if everything is valid, add to database
            if(StudentDB.AddStudent(stu))
            {
                // viewbag data only works for the current request
                ViewBag.StudentAdded = true;
            }

            // let the user know it was successful or Display error message(s)
            return View();
        }
    }
}