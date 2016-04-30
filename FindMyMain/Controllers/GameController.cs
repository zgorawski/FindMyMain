using FindMyMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindMyMain.Controllers
{
    public class GameController : Controller
    {
        // GET: Play
        public ActionResult Play(Summoner summoner = null)
        {
            return View();
        }
    }
}
