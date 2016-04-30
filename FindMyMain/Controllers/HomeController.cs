using FindMyMain.Connection;
using FindMyMain.Connection.Requests;
using FindMyMain.Model;
using FindMyMain.AnswersEngineNamespace;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyMain.ViewModel;

namespace FindMyMain.Controllers
{
    public class HomeController : Controller
    {
        // 26703022
        // 26612832

        // TODO:

        // mastery level from playerID

        // champion from championID

        // helper for image url formating
        // http://ddragon.leagueoflegends.com/cdn/6.8.1/img/champion/Aatrox.png

        // strongly typed view model

        // return RedirectToAction("LogIn", "Account", new { area = "Admin" });

        // GET: Home
        public ActionResult Index(string error = "")
        {
            //var apiConnection = new RiotAPIConnection();

            //var recentGamesRequest = new RecentGamesRequest(Region.EUNE, 26703022);
            //var recentGamesResult = apiConnection.PerformRequest<Games>(recentGamesRequest);
            //if (recentGamesResult.isSuccess)
            //{
            //    var randomFellow = recentGamesResult.value.RandomFellowPlayer();
            //    ViewBag.FellowId = randomFellow.summonerId;
            //}

            //var summonerRequest = new GetSummonerRequest(Region.EUNE, 26703022);
            //var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            //if (summonersResult.isSuccess)
            //{
            //    var summoner = summonersResult.value[26703022.ToString()];
            //    ViewBag.SummonerName = summoner.name;
            //}

            //var allChampionsRequest = new AllChampionsRequest(Region.EUNE);
            //var allChampionsResult = apiConnection.PerformRequest<Champions>(allChampionsRequest);
            //if (allChampionsResult.isSuccess)
            //{
            //    var aatrox = allChampionsResult.value.data["Aatrox"];
            //    ViewBag.ChampionData = aatrox.name;
            //}

            //var topMasteryRequest = new TopChampionMasteryRequest(Region.EUNE, 26612832);
            //var topMasteryResult = apiConnection.PerformRequest<List<Mastery>>(topMasteryRequest);
            //if (topMasteryResult.isSuccess)
            //{
            //    ViewBag.MasteryGrade = topMasteryResult.value.FirstOrDefault().highestGrade;
            //}

            //var answersEngine = new AnswersEngine();
            //var answer = answersEngine.Answer(KnownChampion.Gragas, KnownChampion.Tryndamere);
            //ViewBag.Answer = answer;

            HomePageViewModel viewModel = new HomePageViewModel() {
                Error = error,
                AvailableRegions = new SelectList(RegionUtility.AllRegionsWithNames(), "value", "key")
            };
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Play(HomePageViewModel viewModel)
        {
            if (!Enum.IsDefined(typeof(Region), viewModel.PlayerInput.Region) ||
                string.IsNullOrWhiteSpace(viewModel.PlayerInput.SummonerName))
            {
                return RedirectToAction("Index", new { error = "Something is wrong with provided summoner name or region" });
            }

            var region = (Region)viewModel.PlayerInput.Region;
            var summonerName = viewModel.PlayerInput.SummonerName;

            var apiConnection = new RiotAPIConnection();
            var summonerRequest = new GetSummonerByNameRequest(region, summonerName);

            var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            if (summonersResult.isSuccess && summonersResult.value != null && summonersResult.value.ContainsKey(summonerName) )
            {
                var summoner = summonersResult.value[summonerName];
                return RedirectToAction("Play", "Game", new { summoner = summoner });
            }
            else
            {
                return RedirectToAction("Index", new { error = "Could not find Summoner." });
            }
        }
    }
}