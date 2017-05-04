using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using ConsoleApplication.Models.Entities;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {

        MyDbContext db = new MyDbContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            // db.Students.Add(new Student()
            // {
            //     FirstName = "Claus", 
            //     LastName = "Bove",
            //     EnrollmenDate = new DateTime(1990,10,22)
            // });
            // db.SaveChanges();

            List<Student> students = db.Students.ToList();

            ViewBag.Y = students;
            return View();
        }

        // Create

        // Delete

        // Update

        public IActionResult About()
        {
            return View();
        }

    }
}
