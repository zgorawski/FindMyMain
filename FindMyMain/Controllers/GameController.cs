using FindMyMain.AnswersEngineNamespace;
using FindMyMain.Connection;
using FindMyMain.Connection.Requests;
using FindMyMain.Model;
using FindMyMain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace FindMyMain.Controllers
{
    public class GameController : Controller
    {
        const string TargetChampionId = "targetChampionId";

        // GET: Play
        public ActionResult Play(Region? region = null, long? summonerId = null)
        {
            if (!summonerId .HasValue|| !region.HasValue) { return RedirectToAction("Index", "Home"); }

            var apiConnection = new RiotAPIConnection();

            // get last game(s) of given summoner
            var recentGamesRequest = new RecentGamesRequest(region.Value, summonerId.Value);
            var recentGamesResult = apiConnection.PerformRequest<Games>(recentGamesRequest);

            // generate game seed
            var gameSeed = GameSeed.GenerateGameSeed(recentGamesResult.value.games);
            if (!recentGamesResult.isSuccess || gameSeed == null ) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            // get main champion of player from seed
            var topMasteryRequest = new TopChampionMasteryRequest(region.Value, gameSeed.FellowPlayerId);
            var topMasteryResult = apiConnection.PerformRequest<List<Mastery>>(topMasteryRequest);
            if (!topMasteryResult.isSuccess || topMasteryResult.value.Count == 0) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            var targetChampionId = topMasteryResult.value.FirstOrDefault().championId; 
            gameSeed.TargetChampionId = targetChampionId;
            Session[TargetChampionId] = targetChampionId;

            // get name of player from seed
            var summonerRequest = new GetSummonerRequest(region.Value, gameSeed.FellowPlayerId);
            var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            if (!summonersResult.isSuccess || summonersResult.value == null || summonersResult.value.Count == 0) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            var fellowName = summonersResult.value[gameSeed.FellowPlayerId.ToString()].name;
            
            // prepare view model
            var allChampionsRequest = new AllChampionsRequest(region.Value);
            var allChampionsResult = apiConnection.PerformRequest<Champions>(allChampionsRequest);
            if (!allChampionsResult.isSuccess) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            var gameVersionsRequest = new GameVersionsRequest(region.Value);
            var gameVersionsResult = apiConnection.PerformRequest<List<string>>(gameVersionsRequest);
            if (!gameVersionsResult.isSuccess || gameVersionsResult.value.Count == 0) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            return View(new GameViewModel()
            {
                Champions = allChampionsResult.value.data.Values,
                PlayerChampionName = KnownChampionUtility.ChampionIdToName(gameSeed.PlayerChampionId),
                FellowPlayedChampionName = KnownChampionUtility.ChampionIdToName(gameSeed.FellowPlayedChampionId),
                FellowPlayerName = fellowName,
                SameTeam = gameSeed.SameTeam,
                NGamesAgo = gameSeed.NGamesAgo,
                GameVersion = gameVersionsResult.value.First()
            });
        }


        public ActionResult SelectedChampion(int? championId)
        {
            var selectedChampion = KnownChampionUtility.TryCast(championId);
            var targetChampion = KnownChampionUtility.TryCast((int?)Session[TargetChampionId]);

            if (selectedChampion == null || targetChampion == null) { return Json(new AnswerViewModel() { Error = "Unknown champion" }); }
                        
            var answersEngine = new AnswersEngine();
            var answer = answersEngine.Answer(selectedChampion.Value, targetChampion.Value);

            var json = Json(new AnswerViewModel() { IsMain = false, Answer = answer }, JsonRequestBehavior.AllowGet);

            return json;
        }
    }
}
