using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Model
{
    public class Games
    {
        public List<Game> games { get; set; }
    }

    public class Game
    {
        public List<FellowPlayer> fellowPlayers { get; set; }
        public int championId { get; set; }
        public int teamId { get; set; }
    }

    public class FellowPlayer
    {
        public int championId { get; set; }
        public long summonerId { get; set; }
        public int teamId { get; set; }
    }

    public  class GameSeed
    {
        public int PlayerChampionId { get; set; }
        public long FellowPlayerId { get; set; }
        public int FellowPlayerChampionId { get; set; }
        public bool SameTeam { get; set; }
        public int NGamesAgo { get; set; }

        public long TargetChampionId { get; set; }

        public static GameSeed GenerateGameSeed(List<Game> games)
        {
            if (games == null || games.Count == 0) { return null; }

            var random = new Random();

            var randomGameNumber = random.Next(games.Count);
            var randomGame = games[randomGameNumber];
            var randomFellow = randomGame.fellowPlayers[random.Next(randomGame.fellowPlayers.Count)];

            return new GameSeed()
            {
                PlayerChampionId = randomGame.championId,
                NGamesAgo = randomGameNumber + 1,
                SameTeam = randomGame.teamId == randomFellow.teamId,
                FellowPlayerId = randomFellow.summonerId,
                FellowPlayerChampionId = randomFellow.championId
            };
        }
    }
}