﻿using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
