using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using PersonalWebsite.Models.WorkExperience;
using System.Collections.Generic;

namespace PersonalWebsite.Controllers
{
    public class WorkExperienceController : Controller
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
                        Name = "Academics",
                        Class = "button button--primary button--2",
                        URL = "/Academics",
                    },
                    new ButtonViewModel
                    {
                        Name = "Download Resume",
                        Class = "button button--secondary button--2 button--disabled",
                        //URL = "https://drive.google.com/uc?id=15AJ0na3ue7QVX0CXb4f1mhgLzgHXuxEH&export=download",
                        URL = "#",
                        TooltipText = "Sorry, this resume is currently locked at the moment.",
                        Disabled = true
                    },
                }
            };

            return View("Index", _ViewModel);
        }
    }
}