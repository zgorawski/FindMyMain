using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.ViewModel
{
    public class AnswerViewModel
    {
        public int ChampionId { get; set; }
        public string Error { get; set; }
        public bool IsMain { get; set; }
        public string Answer { get; set; }
    }
}