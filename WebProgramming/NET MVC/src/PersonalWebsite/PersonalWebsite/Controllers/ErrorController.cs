using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult NotFoundError()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }

        public ViewResult ServerError()
        {
            Response.StatusCode = 500;
            return View("ServerError");
        }
    }
}