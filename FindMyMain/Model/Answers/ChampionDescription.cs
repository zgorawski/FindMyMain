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

        public static ChampionDescription? GetChampionDescription(KnownChampion champion)
        {
            ChampionDescription? result = null;

            switch (champion)
            {
                case KnownChampion.Aatrox:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Thresh:
                    result = new ChampionDescription(champion,
                        "Oh, the eternity we shall spend together.",
                        RoleTag.Controller,
                        RegionTag.ShadowIsles,
                        null,
                        new HashSet<SkinTag> { SkinTag.Championship, SkinTag.BloodMoon },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Nautilus, "We both likes to pull things" },
                            { KnownChampion.Lucian, "I was this third..." }});
                    break;
                case KnownChampion.Tryndamere:
                    result = new ChampionDescription(champion,
                        "Into battle",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.WarringKingdoms },
                        null);
                    break;
                case KnownChampion.Gragas:
                    result = new ChampionDescription(champion,
                        "Time to roll out the barrel!",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Christmas },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Jax, "You are looking for my drinking buddy!" } });
                    break;
                case KnownChampion.AurelionSol:
                    result = new ChampionDescription(champion,
                        "The stars look very different today.",
                        RoleTag.Mage,
                        RegionTag.MountTargon,
                        null,
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.Shyvana, "We are somehow connected by kind" } });
                    break;
                case KnownChampion.Cassiopeia:
                    result = new ChampionDescription(champion,
                        "Come, look me in the eyes.",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        null,
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Sivir, "You are looking for one with whom I explored Shurima." },
                            { KnownChampion.Katarina, "You are looking for another one from Du Couteau family." }});
                    break;
                case KnownChampion.Poppy:
                    result = new ChampionDescription(champion,
                        "I'm no hero - just a Yordle with a hammer.",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        null,
                        null);
                    break;
                case KnownChampion.Ryze:
                    result = new ChampionDescription(champion,
                        "I will show you arcane magic!",
                        RoleTag.Mage,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.School, SkinTag.Pirate },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Nocturne, "I've once fight him in a movie" } });
                    break;
                case KnownChampion.Sion:
                    result = new ChampionDescription(champion,
                        "More enemies!",
                        RoleTag.Tank,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha, SkinTag.Hextech },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Galio, "What?! His main champion is my oposite - damacian eternal guardian?" } });
                    break;
                case KnownChampion.Annie:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Jhin:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nautilus:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Karma:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Lux:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Ahri:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Olaf:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Viktor:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Singed:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Garen:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Anivia:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Maokai:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Lissandra:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Morgana:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Evelynn:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Fizz:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Heimerdinger:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle, PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Zed:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Rumble:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Mordekaiser:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities, PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Sona:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Katarina:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.KogMaw:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Ashe:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Lulu:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Karthus:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Alistar:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Darius:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Vayne:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Udyr:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal, PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Varus:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Jayce:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Leona:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Syndra:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Pantheon:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Khazix:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Riven:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Corki:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Caitlyn:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Azir:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nidalee:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter, PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Kennen:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Galio:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Veigar:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Bard:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Gnar:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle, PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Malzahar:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Graves:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Vi:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Kayle:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Irelia:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.LeeSin:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Illaoi:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Elise:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Shapeshifter, PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Volibear:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nunu:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.TwistedFate:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Jax:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Shyvana:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Kalista:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.DrMundo:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.TahmKench:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Diana:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Brand:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Sejuani:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Vladimir:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Zac:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.RekSai:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Quinn:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Akali:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Tristana:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Hecarim:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Sivir:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Lucian:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Rengar:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Warwick:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Skarner:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Malphite:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Yasuo:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Xerath:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Teemo:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Renekton:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nasus:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Draven:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Shaco:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Swain:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Janna:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Talon:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Ziggs:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Ekko:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Orianna:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.FiddleSticks:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Fiora:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Chogath:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Rammus:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Leblanc:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Soraka:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities, PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Zilean:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nocturne:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Jinx:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Yorick:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Urgot:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Kindred:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.MissFortune:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.MonkeyKing:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Blitzcrank:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Shen:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Braum:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.XinZhao:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Twitch:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.MasterYi:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Taric:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.MountTargon,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Amumu:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Gangplank:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Trundle:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Kassadin:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Velkoz:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Zyra:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Nami:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.JarvanIV:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Ezreal:
                    result = new ChampionDescription(champion,
                        "True warriors are born in blood!",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}