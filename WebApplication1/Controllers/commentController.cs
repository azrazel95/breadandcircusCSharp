﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
