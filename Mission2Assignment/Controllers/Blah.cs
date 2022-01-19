using Microsoft.AspNetCore.Mvc;
using Mission2Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2Assignment.Controllers
{
    public class Blah : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException(); This was just a practice error, to see the different ways we can handle them

            return View();
        }
        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeCalc(GradeCalcModel model) //Could call the model anything, its just a variable name
        {
            return View();
        }
    }
}
