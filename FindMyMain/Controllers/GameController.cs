using FindMyMain.Connection;
using FindMyMain.Connection.Requests;
using FindMyMain.Model;
using FindMyMain.ViewModel;
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

            // get name of player from seed
            var summonerRequest = new GetSummonerRequest(region.Value, gameSeed.FellowPlayerId);
            var summonersResult = apiConnection.PerformRequest<Dictionary<string, Summoner>>(summonerRequest);
            if (!summonersResult.isSuccess || summonersResult.value == null || summonersResult.value.Count == 0) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            var fellowName = summonersResult.value[gameSeed.FellowPlayerId.ToString()].name;
            
            // TODO: store gameSeed !!!

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


        public string SelectedChampion(int? championId)
        {
            return $"OMG {championId}";
        }
    }
}
