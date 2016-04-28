using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Model.Answers
{
    public struct ChampionDescription
    {
        public KnownChampion Champion { get; private set; }
        public string WelcomeQuote { get; private set; }

        public RoleTag Role { get; private set; }
        public RegionTag Region { get; private set; }
        public HashSet<PerkTag> Perks { get; private set; }
        public HashSet<SkinTag> Skins { get; private set; }
        
        public Dictionary<KnownChampion, string> SpecialQuotes { get; private set; }

        public ChampionDescription(KnownChampion champion, string welcomeQuote, RoleTag role, RegionTag region, HashSet<PerkTag> perks, HashSet<SkinTag> skins, Dictionary<KnownChampion, string> specialQuotes)
        {
            Champion = champion;
            WelcomeQuote = welcomeQuote;
            Role = role;
            Region = region;
            Perks = perks;
            Skins = skins;
            SpecialQuotes = specialQuotes;
        }
    }
}