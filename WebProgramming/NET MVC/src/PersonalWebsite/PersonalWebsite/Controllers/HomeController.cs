using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult AboutMe()
        {
            return View();
        }

        public ViewResult ContactMe()
        {
            return View();
        }
    }
}