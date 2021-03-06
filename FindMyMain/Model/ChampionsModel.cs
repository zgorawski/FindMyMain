﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Model
{
    public class Champions
    {
        public Dictionary<string, Champion> data { get; set; }
        public string version { get; set; }
    }

    public class Champion
    {
        public int id { get; set; }
        public string name { get; set; }
        public ChampionImage image { get; set; }
    }

    public class ChampionImage
    {
        public string full { get; set; }
    }
}