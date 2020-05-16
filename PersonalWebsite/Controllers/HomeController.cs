using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalWebsite.Models;
using PersonalWebsite.Models.Home;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _Logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _Logger = logger;
        }

        public IActionResult Index()
        {
            IndexViewModel _ViewModel = new IndexViewModel
            {
                Buttons = new List<ButtonViewModel>
                {
                    new ButtonViewModel
                    {
                        Name = "Work Experience",
                        Class = "button button--primary button--2",
                        URL = "/WorkExperience",
                    },
                    new ButtonViewModel
                    {
                        Name = "Academics",
                        Class = "button button--primary button--2",
                        URL = "/Academics",
                    },
                    new ButtonViewModel
                    {
                        Name = "Download Resume",
                        Class = "button button--secondary button--2",
                        URL = "https://drive.google.com/uc?id=15AJ0na3ue7QVX0CXb4f1mhgLzgHXuxEH&export=download",
                    },
                }
            };

            return View("Index", _ViewModel);
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
