using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BaseCampCodingAcademy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("sponsors")]
        public IActionResult Sponsors()
        {
            return View();
        }

        [Route("news-press")]
        public IActionResult NewsAndPress()
        {
            return View();
        }

        [Route("student-portfolios")]
        public IActionResult StudentPortfolios()
        {
            return View();
        }

        [Route("curriculum")]
        public IActionResult Curriculum()
        {
            return View();
        }

        [Route("curriculum-details")]
        public IActionResult CurriculumDetails()
        {
            return View();
        }

        [Route("nondiscriminatory-policy")]
        public IActionResult NondiscriminatoryPolicy()
        {
            return View();
        }

        [Route("apply")]
        public IActionResult Apply()
        {
            return Redirect("http://goo.gl/forms/TCZqJGyiOD");
        }

        [Route("nominate")]
        public IActionResult Nominate()
        {
            return Redirect("http://goo.gl/forms/MCLxyI4i1r");
        }

        [Route("fundraiser")]
        public IActionResult Fundraiser()
        {
            return Redirect("https://www.eventbrite.com/e/base-camp-coding-academy-2018-fundraising-celebration-tickets-44278725861");
        }

        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }

        [Route("version")]
        public IActionResult Version()
        {
            var framework = Assembly
                .GetEntryAssembly()?
                .GetCustomAttribute<TargetFrameworkAttribute>()?
                .FrameworkName;

            /* 
            var stats = new
            {                
                OsPlatform = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                AspDotnetVersion = framework
            };
            */

            ViewData["OsPlatform"] = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            ViewData["AspDotNetVersion"] = framework;

            return View();
        }
    }
}
