using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.ViewModel
{
    public class AnswerViewModel
    {
        public bool IsMain { get; set; }
        public string Error { get; set; }

        public int ChampionId { get; set; }
        public string ChampionImageName { get; set; }
        public string ChampionName { get; set; }

        public string Answer { get; set; }

        public string GameVersion { get; set; }
        public int FellowIconId { get; set; }
        public string FellowName { get; set; }
    }
}