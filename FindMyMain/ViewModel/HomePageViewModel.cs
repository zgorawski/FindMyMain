using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindMyMain.ViewModel
{
    public class HomePageViewModel
    {
        public SelectList AvailableRegions { get; set; }
        public string Error { get; set; }

        public PlayerInput PlayerInput { get; set; }
    }

    public class PlayerInput
    {
        public string SummonerName { get; set; }
        public int Region { get; set; }
    }
}