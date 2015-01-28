using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldPlugin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HelloWorldController : Controller
    {
        // GET: HelloWordl
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }
    }
}