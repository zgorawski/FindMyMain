using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindMyMain.Controllers
{
    public class HomeController : Controller
    {
        private static string apiKey = ConfigurationManager.AppSettings["APIKey"];

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ApiKey = apiKey;

            return View();
        }
    }
}