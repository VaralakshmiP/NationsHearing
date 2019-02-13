using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationsHearing.Models;

namespace NationsHearing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
       // ViewBag.option = "thisWeek";
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

        public void SelectedOption(string data)
        {
            ViewData["option"] = data;
            
        }
        [HttpGet]
        public IActionResult clinicResult(string selectedValue) {
            ViewBag.option = selectedValue;
            return PartialView("_ClinicStatistics");
        }
    }
}
