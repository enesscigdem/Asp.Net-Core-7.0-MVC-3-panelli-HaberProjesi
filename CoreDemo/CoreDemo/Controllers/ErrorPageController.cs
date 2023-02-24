using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ErrorPageController : Controller
    {
        [HttpGet]
        public IActionResult Error1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Error1(int code)
        {
            return RedirectToAction("Index","Login");
        }
    }
}