﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAspApp.Models;

namespace WebAspApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Numbers(int id)
        {
            int gogo = id;
            ViewBag.jkl = gogo;
            return this.View();
        }

        [HttpPost]
        public IActionResult Numbers(string PichMich)
        {
            int gofg = int.Parse(PichMich);
            ViewBag.jkl = gofg;
            return this.View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Good day.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
