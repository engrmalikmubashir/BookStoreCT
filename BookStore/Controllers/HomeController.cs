﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Models;
using System.Dynamic;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // ViewBag.Title = "Engr Malik Mubashir";
            // dynamic data = new ExpandoObject();
            // data.Id = 1;
            // data.Name = "Mubashir";
            // ViewBag.Data = data;
            //
            // ViewBag.Type = new BookModel() { Id = 5, Author = "This is Mubashir" };

            // todo ViewData
            // ViewData["propert1"] = "Malik Mubashir";
            //
            // ViewData["book"] = new BookModel() { Author = "Mubashir", Id = 1 };

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
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
