using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evoke.Smartvoke.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Signin
        public ActionResult Index()
        {
            return View("Index", "_Layout");
        }

    }
}