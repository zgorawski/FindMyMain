﻿using FindMyMain.Connection;
using FindMyMain.Connection.Requests;
using FindMyMain.Model;
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
        
        // GET: Home
        public ActionResult Index()
        {
            var apiConnection = new RiotAPIConnection();

            var gameVersionRequest = new GameVersionRequest(LolRegion.eune);
            var gameVersionResult = apiConnection.PerformRequest<List<string>>(gameVersionRequest);
            if (gameVersionResult.isSuccess)
            {
                ViewBag.GameVersion = gameVersionResult.value.FirstOrDefault();
            }

            // 26703022

            var recentGamesRequest = new RecentGamesRequest(LolRegion.eune, 26703022);
            var recentGamesResult = apiConnection.PerformRequest<Games>(recentGamesRequest);
            if (recentGamesResult.isSuccess)
            {
                var randomFellow = recentGamesResult.value.RandomFellowPlayer();
                int aa = 0;
            }
            

            return View();
        }
    }
}