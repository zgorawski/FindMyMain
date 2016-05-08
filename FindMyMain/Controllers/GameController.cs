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
        const string GameVersion = "gameVersion";
        const string FellowName = "fellowName";
        const string FellowIcon = "fellowIcon";

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
            Session[FellowName] = fellowName;

            var fellowIconId = summonersResult.value[gameSeed.FellowPlayerId.ToString()].profileIconId;
            Session[FellowIcon] = fellowIconId;

            // prepare view model
            var allChampionsRequest = new AllChampionsRequest(region.Value);
            var allChampionsResult = apiConnection.PerformRequest<Champions>(allChampionsRequest);
            if (!allChampionsResult.isSuccess) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }

            var gameVersionsRequest = new GameVersionsRequest(region.Value);
            var gameVersionsResult = apiConnection.PerformRequest<List<string>>(gameVersionsRequest);
            if (!gameVersionsResult.isSuccess || gameVersionsResult.value.Count == 0) { return RedirectToAction("Index", "Home", "Failed to prepare a game"); }
            var gameVersion = gameVersionsResult.value.First();
            Session[GameVersion] = gameVersion;

            return View(new GameViewModel()
            {
                Champions = allChampionsResult.value.data.Values.OrderBy(x => x.name),
                PlayerChampionName = KnownChampionUtility.ChampionIdToName(gameSeed.PlayerChampionId),
                FellowPlayerChampionName = KnownChampionUtility.ChampionIdToName(gameSeed.FellowPlayerChampionId),
                FellowPlayerName = fellowName,
                FellowPlayerIconId = fellowIconId,
                SameTeam = gameSeed.SameTeam,
                NGamesAgo = gameSeed.NGamesAgo,
                GameVersion = gameVersion
            });
        }


        public ActionResult SelectedChampion(int? championId)
        {
            var selectedChampion = KnownChampionUtility.TryCast(championId);

            var targetChampion = KnownChampionUtility.TryCast((int?)Session[TargetChampionId]);
            var gameVersion = (string)Session[GameVersion];
            var fellowName = (string)Session[FellowName];
            var fellowIcon = (int)Session[FellowIcon];

            if (selectedChampion == null || targetChampion == null || string.IsNullOrEmpty(gameVersion) || string.IsNullOrEmpty(fellowName))
            {
                return Json(new AnswerViewModel() { Error = "Unknown champion" });
            }
                        
            var answersEngine = new AnswersEngine();
            var answer = answersEngine.Answer(selectedChampion.Value, targetChampion.Value);

            // dirty
            var championImgName = Enum.GetName(typeof(KnownChampion), selectedChampion.Value);

            var json = Json(new AnswerViewModel() {
                IsMain = (selectedChampion.Value == targetChampion.Value),
                Answer = answer,
                ChampionId = championId.Value,
                GameVersion = gameVersion,
                ChampionImageName = championImgName,
                FellowName = fellowName,
                FellowIconId = fellowIcon,
                ChampionName = KnownChampionUtility.ChampionIdToName(championId.Value)
            }, JsonRequestBehavior.AllowGet);

            return json;
        }
    }
}
