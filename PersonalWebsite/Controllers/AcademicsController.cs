using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using PersonalWebsite.Models.Academics;
using System.Collections.Generic;

namespace PersonalWebsite.Controllers
{
    public class AcademicsController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel _ViewModel = new IndexViewModel
            {
                Buttons = new List<ButtonViewModel>
                {
                    new ButtonViewModel
                    {
                        Name = "Home",
                        Class = "button button--primary button--2",
                        IconClass = "fas fa-caret-left button__icon",
                        URL = "/Home",
                    },
                    new ButtonViewModel
                    {
                        Name = "Work Experience",
                        Class = "button button--primary button--2",
                        URL = "/WorkExperience",
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
    }
}
