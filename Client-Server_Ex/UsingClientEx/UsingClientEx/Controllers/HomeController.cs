﻿using Microsoft.AspNetCore.Mvc;

namespace UsingClientEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
