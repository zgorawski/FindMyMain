using FindMyMain.Connection;
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
                        
            var recentGamesRequest = new RecentGamesRequest(LolRegion.eune, 26703022);
            var recentGamesResult = apiConnection.PerformRequest<Games>(recentGamesRequest);
            if (recentGamesResult.isSuccess)
            {
                var randomFellow = recentGamesResult.value.RandomFellowPlayer();
                ViewBag.FellowId = randomFellow.summonerId;
            }

            var summonerRequest = new GetSummonerRequest(LolRegion.eune, 26703022);
            var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            if (summonersResult.isSuccess)
            {
                var summoner = summonersResult.value[26703022.ToString()];
                ViewBag.SummonerName = summoner.name;
            }

            var allChampionsRequest = new AllChampionsRequest(LolRegion.eune);
            var allChampionsResult = apiConnection.PerformRequest<Champions>(allChampionsRequest);
            if (allChampionsResult.isSuccess)
            {
                var aatrox = allChampionsResult.value.data["Aatrox"];
                ViewBag.ChampionData = aatrox.name;
            }


            // TODO:
            // 26703022

            // mastery level from playerID
            // list of all champions with images
            // champion from championID

            // helper for image url formating
            // http://ddragon.leagueoflegends.com/cdn/6.8.1/img/champion/Aatrox.png

            // strongly typed view model

            return View();
        }
    }
}