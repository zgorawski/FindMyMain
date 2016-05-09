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
        // GET: Home
        public ActionResult Index(string error = "")
        {
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
                return RedirectToAction("Index", new { error = "Something is wrong with the provided summoner name or region." });
            }

            var region = (Region)viewModel.PlayerInput.Region;
            var summonerName = viewModel.PlayerInput.SummonerName;

            var apiConnection = new RiotAPIConnection();

            var summonerRequest = new GetSummonerByNameRequest(region, summonerName);
            var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            if (summonersResult.isSuccess && summonersResult.value != null && summonersResult.value.ContainsKey(summonerName) )
            {
                var summoner = summonersResult.value[summonerName];
                return RedirectToAction("Play", "Game", new { region = region, summonerId = summoner.id });
            }
            else
            {
                return RedirectToAction("Index", new { error = "Could not find Summoner." });
            }
        }
    }
}