using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewFun.Models;

namespace ViewFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Person somePerson = new Person()
            {
                FirstName = "Bobs And",
                LastName = "Floats"
            };
            return View(somePerson);
        }
    }
}
