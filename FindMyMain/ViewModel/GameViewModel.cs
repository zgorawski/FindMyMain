using FindMyMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.ViewModel
{
    public class GameViewModel
    {
        public string PlayerChampionName { get; set; }
        public string FellowPlayerName { get; set; }
        public string FellowPlayerChampionName { get; set; }
        public int FellowPlayerIconId { get; set; }
        public bool SameTeam { get; set; }
        public int NGamesAgo { get; set; }
        public IEnumerable<Champion> Champions { get; set; }
        public string GameVersion { get; set; }
    }
}