using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Model
{
    public class Games
    {
        public List<Game> games { get; set; }

        public FellowPlayer RandomFellowPlayer()
        {
            var random = new Random();

            var randomGame = games[random.Next(games.Count)];
            var randomFellow = randomGame.fellowPlayers[random.Next(randomGame.fellowPlayers.Count)];

            return randomFellow;
        }
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
}