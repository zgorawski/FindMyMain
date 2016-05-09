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
                        "",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Tryndamere, "You are looking for my greatest creation. His rage will shape the world." } });
                    break;
                case KnownChampion.Thresh:
                    result = new ChampionDescription(champion,
                        "",
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
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.WarringKingdoms },
                        null);
                    break;
                case KnownChampion.Gragas:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Christmas },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Jax, "You are looking for my drinking buddy!" } });
                    break;
                case KnownChampion.AurelionSol:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.MountTargon,
                        null,
                        null,
                        null);
                    break;
                case KnownChampion.Cassiopeia:
                    result = new ChampionDescription(champion,
                        "",
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
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        null,
                        null);
                    break;
                case KnownChampion.Ryze:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.School, SkinTag.Pirate },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Nocturne, "I've once fight him in a movie" } });
                    break;
                case KnownChampion.Sion:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha, SkinTag.Hextech },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Galio, "What?! His main champion is my oposite - damacian eternal guardian?" } });
                    break;
                case KnownChampion.Annie:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Hextech, SkinTag.Sweetheart, SkinTag.ChineseNewYear},
                        null);
                    break;
                case KnownChampion.Jhin:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.HighNoon },
                        null);
                    break;
                case KnownChampion.Nautilus:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Bilgewater,
                        null,
                        new HashSet<SkinTag> { SkinTag.Warden },
                        null);
                    break;
                case KnownChampion.Karma:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.OrderOfLotus, SkinTag.Warden },
                        null);
                    break;
                case KnownChampion.Lux:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Commando,SkinTag.SteelLegion },
                        null);
                    break;
                case KnownChampion.Ahri:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Ionia,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Academy },
                        null);
                    break;
                case KnownChampion.Olaf:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Pentakill, SkinTag.Marauder },
                        null);
                    break;
                case KnownChampion.Viktor:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Zaun,
                        null,
                        null,
                     new Dictionary<KnownChampion, string> { { KnownChampion.Heimerdinger, "His work is a masterpiece, but his methods are inadmissible" } });
                    break;
                case KnownChampion.Singed:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Zaun,
                        null,
                        new HashSet<SkinTag> { SkinTag.Hextech, SkinTag.SnowDay, SkinTag.RiotSquad },
                        null);
                    break;
                case KnownChampion.Garen:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Commando },
                        null);
                    break;
                case KnownChampion.Anivia:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Hextech },
                        null);
                    break;
                case KnownChampion.Maokai:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Haunted},
                        null);
                    break;
                case KnownChampion.Lissandra:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Program },
                        null);
                    break;
                case KnownChampion.Morgana:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.Victorious },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Kayle, "I want to deafeat her again and again" } });
                    break;
                case KnownChampion.Evelynn:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.ShadowIsles,
                        null,
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.TwistedFate, "I'd like to dance with him one more time..." } });
                    break;
                case KnownChampion.Fizz:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Bilgewater,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.SuperGalaxy },
                        null);
                    break;
                case KnownChampion.Heimerdinger:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Piltover,
                        new HashSet<PerkTag> { PerkTag.Yordle, PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Zed:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Project },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Shen, "He seeks to challenge me" } });
                    break;
                case KnownChampion.Rumble:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.SuperGalaxy },
                        null);
                    break;
                case KnownChampion.Mordekaiser:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.ShadowIsles,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities, PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Pentakill},
                        null);
                    break;
                case KnownChampion.Sona:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Pentakill, SkinTag.Sweetheart, SkinTag.Arcade },
                        null);
                    break;
                case KnownChampion.Katarina:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.ChineseNewYear},
                        new Dictionary<KnownChampion, string> { { KnownChampion.Garen, "Come on! It was only ONE date!" } });
                    break;
                case KnownChampion.KogMaw:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Void,
                        null,
                        new HashSet<SkinTag> { SkinTag.Battlecast, SkinTag.ChineseNewYear },
                        null);
                    break;
                case KnownChampion.Ashe:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Sweetheart, SkinTag.Marauder },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Lissandra, "There can only be one queen!" } });
                    break;
                case KnownChampion.Lulu:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        null);
                    break;
                case KnownChampion.Karthus:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.ShadowIsles,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Pentakill },
                        null);
                    break;
                case KnownChampion.Alistar:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Marauder },
                        null);
                    break;
                case KnownChampion.Darius:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.Academy },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Draven, "You are looking for my brother" } });
                    break;
                case KnownChampion.Vayne:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Sweetheart, SkinTag.Dragonslayer, SkinTag.Arclight},
                        null);
                    break;
                case KnownChampion.Udyr:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.Animal, PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.DefinitelyNot},
                        null);
                    break;
                case KnownChampion.Varus:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Sweetheart, SkinTag.Arclight },
                        null);
                    break;
                case KnownChampion.Jayce:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Piltover,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter },
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.Heimerdinger, "Ah, yes, once I borrowed some 'hexpertise' from him " } });
                    break;
                case KnownChampion.Leona:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.MountTargon,
                        null,
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Diana, "Now you should know what her main champion is" } });
                    break;
                case KnownChampion.Syndra:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.SnowDay },
                        null);
                    break;
                case KnownChampion.Pantheon:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.MountTargon,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Dragonslayer },
                        null);
                    break;
                case KnownChampion.Khazix:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Void,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha, SkinTag.GuardianOfTheSands },
                        null);
                    break;
                case KnownChampion.Riven:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.ChineseNewYear, SkinTag.Arcade },
                        null);
                    break;
                case KnownChampion.Corki:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.ChineseNewYear },
                        null);
                    break;
                case KnownChampion.Caitlyn:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Piltover,
                        null,
                        new HashSet<SkinTag> { SkinTag.Officer },
                        null);
                    break;
                case KnownChampion.Azir:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Animal },
                        null,
                        null);
                    break;
                case KnownChampion.Nidalee:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter, PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Headhunter, SkinTag.ChineseNewYear },
                        null);
                    break;
                case KnownChampion.Kennen:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Ionia,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Medical },
                        null);
                    break;
                case KnownChampion.Galio:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Hextech, SkinTag.Commando },
                        null);
                    break;
                case KnownChampion.Veigar:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Arcade },
                        null);
                    break;
                case KnownChampion.Bard:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.SnowDay },
                        null);
                    break;
                case KnownChampion.Gnar:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.Yordle, PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.SnowDay },
                        null);
                    break;
                case KnownChampion.Malzahar:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Chogath, "Ahh! You are looking for one from the Void." },
                            { KnownChampion.KogMaw, "Ahh! You are looking for one from the Void." },
                            { KnownChampion.Khazix, "Ahh! You are looking for one from the Void." },
                            { KnownChampion.Velkoz, "Ahh! You are looking for one from the Void." },
                            { KnownChampion.RekSai, "Ahh! You are looking for one from the Void." },
                            { KnownChampion.Malzahar, "I've send his daughter into the Void" }
                        });
                    break;
                case KnownChampion.Graves:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Bilgewater,
                        null,
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        new Dictionary<KnownChampion, string> { { KnownChampion.TwistedFate, "You are looking for my crime partner" } });
                    break;
                case KnownChampion.Vi:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Piltover,
                        null,
                        new HashSet<SkinTag> { SkinTag.Debonair, SkinTag.Officer },
                        null);
                    break;
                case KnownChampion.Kayle:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Morgana, "My fallen sister..." } });
                    break;
                case KnownChampion.Irelia:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.OrderOfLotus },
                        null);
                    break;
                case KnownChampion.LeeSin:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        null);
                    break;
                case KnownChampion.Illaoi:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Bilgewater,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        null);
                    break;
                case KnownChampion.Elise:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.ShadowIsles,
                        new HashSet<PerkTag> { PerkTag.PetChampion, PerkTag.Shapeshifter, PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.BloodMoon },
                        null);
                    break;
                case KnownChampion.Volibear:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Officer },
                        null);
                    break;
                case KnownChampion.Nunu:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.TwistedFate:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.HighNoon },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Graves, "You are looking for my crime partner" },
                            { KnownChampion.Evelynn, "I'd like to dance with her one more time..." }});
                    break;
                case KnownChampion.Jax:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Vandal, SkinTag.Warden },
                        null);
                    break;
                case KnownChampion.Shyvana:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        new HashSet<PerkTag> { PerkTag.Shapeshifter },
                        new HashSet<SkinTag> { SkinTag.Championship, SkinTag.SuperGalaxy },
                        null);
                    break;
                case KnownChampion.Kalista:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.ShadowIsles,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.BloodMoon, SkinTag.Championship },
                        null);
                    break;
                case KnownChampion.DrMundo:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Zaun,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        null);
                    break;
                case KnownChampion.TahmKench:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.Global },
                        null,
                        null);
                    break;
                case KnownChampion.Diana:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.MountTargon,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Leona, "Day was choosen over night..." } });
                    break;
                case KnownChampion.Brand:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Vandal },
                        null);
                    break;
                case KnownChampion.Sejuani:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Freljord,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Vladimir:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.School, SkinTag.Vandal },
                        null);
                    break;
                case KnownChampion.Zac:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Zaun,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        null);
                    break;
                case KnownChampion.RekSai:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Void,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        null);
                    break;
                case KnownChampion.Quinn:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Damacia,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Akali:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Headhunter, SkinTag.BloodMoon },
                        null);
                    break;
                case KnownChampion.Tristana:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.Pirate },
                        null);
                    break;
                case KnownChampion.Hecarim:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.ShadowIsles,
                        null,
                        new HashSet<SkinTag> { SkinTag.Arcade },
                        null);
                    break;
                case KnownChampion.Sivir:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Shurima,
                        null,
                        new HashSet<SkinTag> { SkinTag.Warden, SkinTag.Victorious },
                        null);
                    break;
                case KnownChampion.Lucian:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Project },
                        null);
                    break;
                case KnownChampion.Rengar:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Headhunter },
                        null);
                    break;
                case KnownChampion.Warwick:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Zaun,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Marauder },
                        null);
                    break;
                case KnownChampion.Skarner:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Battlecast, SkinTag.GuardianOfTheSands },
                        null);
                    break;
                case KnownChampion.Malphite:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        null);
                    break;
                case KnownChampion.Yasuo:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.HighNoon, SkinTag.Project, SkinTag.BloodMoon },
                        null);
                    break;
                case KnownChampion.Xerath:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Battlecast, SkinTag.GuardianOfTheSands },
                        null);
                    break;
                case KnownChampion.Teemo:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.BandleCity,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        null,
                        null);
                    break;
                case KnownChampion.Renekton:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Nasus, "You are looking for my brother" } });
                    break;
                case KnownChampion.Nasus:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.RiotSquad },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Renekton, "You are looking for my brother" } });
                    break;
                case KnownChampion.Draven:
                    result = new ChampionDescription(champion,
                        "TODO",
                        RoleTag.Marksmen,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.PoolParty },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Darius, "You are looking for my brother" } });
                    break;
                case KnownChampion.Shaco:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Swain:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        null,
                        null);
                    break;
                case KnownChampion.Janna:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Zaun,
                        null,
                        new HashSet<SkinTag> { SkinTag.Hextech, SkinTag.Victorious },
                        null);
                    break;
                case KnownChampion.Talon:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Noxus,
                        null,
                        null,
                        null);
                    break;
                case KnownChampion.Ziggs:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Piltover,
                        new HashSet<PerkTag> { PerkTag.Yordle },
                        new HashSet<SkinTag> { SkinTag.PoolParty, SkinTag.SnowDay },
                        null);
                    break;
                case KnownChampion.Ekko:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Zaun,
                        null,
                        new HashSet<SkinTag> { SkinTag.School },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Jinx, "I had crush on her, but she went crazy :(" } });
                    break;
                case KnownChampion.Orianna:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Piltover,
                        null,
                        new HashSet<SkinTag> { SkinTag.Hearthseeker },
                        null);
                    break;
                case KnownChampion.FiddleSticks:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.GuardianOfTheSands },
                        null);
                    break;
                case KnownChampion.Fiora:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.School, SkinTag.Project },
                        null);
                    break;
                case KnownChampion.Chogath:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Void,
                        null,
                        new HashSet<SkinTag> { SkinTag.Battlecast },
                        null);
                    break;
                case KnownChampion.Rammus:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Shurima,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.GuardianOfTheSands },
                        null);
                    break;
                case KnownChampion.Leblanc:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Noxus,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Soraka:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Ionia,
                        new HashSet<PerkTag> { PerkTag.HealthCostAbilities, PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Program },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Bard, "You are looking for other Celestial Being." } });
                    break;
                case KnownChampion.Zilean:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.BloodMoon },
                        null);
                    break;
                case KnownChampion.Nocturne:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Other,
                        null,
                        null,
                        null);
                    break;
                case KnownChampion.Jinx:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Piltover,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Mafia },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Vi, "This looser cannot catch me :D" },
                            { KnownChampion.Caitlyn, "This looser cannot catch me :D" }});
                    break;
                case KnownChampion.Yorick:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.ShadowIsles,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.Pentakill },
                        null);
                    break;
                case KnownChampion.Urgot:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Noxus,
                        null,
                        new HashSet<SkinTag> { SkinTag.Battlecast },
                        null);
                    break;
                case KnownChampion.Kindred:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        new HashSet<SkinTag> { SkinTag.SuperGalaxy },
                        null);
                    break;
                case KnownChampion.MissFortune:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Bilgewater,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mafia, SkinTag.Arcade },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Gangplank, "I've defeated him in the GrugMug Grog Slog competition." } });
                    break;
                case KnownChampion.MonkeyKing:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Ionia,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.MasterYi, "He taught me Wuju style." } });
                    break;
                case KnownChampion.Blitzcrank:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Zaun,
                        null,
                        new HashSet<SkinTag> { SkinTag.RiotSquad, SkinTag.Arcade },
                        null);
                    break;
                case KnownChampion.Shen:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Ionia,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.BloodMoon },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Zed, "You are looking for my father's killer..." },
                            { KnownChampion.Akali, "You are looking for another warrior of Kinokou Order." },
                            { KnownChampion.Kennen, "You are looking for another warrior of Kinokou Order" }});
                    break;
                case KnownChampion.Braum:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Dragonslayer },
                        null);
                    break;
                case KnownChampion.XinZhao:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Commando, SkinTag.WarringKingdoms },
                        null);
                    break;
                case KnownChampion.Twitch:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Zaun,
                        new HashSet<PerkTag> { PerkTag.Animal },
                        new HashSet<SkinTag> { SkinTag.Vandal, SkinTag.Mafia },
                        null);
                    break;
                case KnownChampion.MasterYi:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Ionia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Headhunter, SkinTag.Project },
                        new Dictionary<KnownChampion, string> { { KnownChampion.MonkeyKing, "You are looking for my puppil" } });
                    break;
                case KnownChampion.Taric:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.MountTargon,
                        null,
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.Ezreal, "What do you want from my boy?!" } });
                    break;
                case KnownChampion.Amumu:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Tank,
                        RegionTag.Shurima,
                        null,
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.Annie, "You are looking for my good friend" } });
                    break;
                case KnownChampion.Gangplank:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Bilgewater,
                        new HashSet<PerkTag> { PerkTag.Global },
                        null,
                        new Dictionary<KnownChampion, string> { { KnownChampion.MissFortune, "You are looking for the one that almost killed me" } });
                    break;
                case KnownChampion.Trundle:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Freljord,
                        null,
                        new HashSet<SkinTag> { SkinTag.Officer },
                        new Dictionary<KnownChampion, string> { { KnownChampion.Lissandra, "You are looking for my ally" } });
                    break;
                case KnownChampion.Kassadin:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Slayer,
                        RegionTag.Other,
                        null,
                        new HashSet<SkinTag> { SkinTag.Mecha },
                        new Dictionary<KnownChampion, string> {
                            { KnownChampion.Chogath, "I am trying to protect world from this creature..." },
                            { KnownChampion.KogMaw, "I am trying to protect world from this creature..." },
                            { KnownChampion.Khazix, "I am trying to protect world from this creature..." },
                            { KnownChampion.Velkoz, "I am trying to protect world from this creature..." },
                            { KnownChampion.RekSai, "I am trying to protect world from this creature..." },
                            { KnownChampion.Malzahar, "I am trying to protect world from him" }
                        });
                    break;
                case KnownChampion.Velkoz:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Void,
                        null,
                        new HashSet<SkinTag> { SkinTag.Battlecast },
                        null);
                    break;
                case KnownChampion.Zyra:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Mage,
                        RegionTag.Other,
                        new HashSet<PerkTag> { PerkTag.PetChampion },
                        null,
                        null);
                    break;
                case KnownChampion.Nami:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Controller,
                        RegionTag.Other,
                        null,
                        null,
                        null);
                    break;
                case KnownChampion.JarvanIV:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Fighter,
                        RegionTag.Damacia,
                        null,
                        new HashSet<SkinTag> { SkinTag.Commando, SkinTag.Dragonslayer, SkinTag.WarringKingdoms },
                        null);
                    break;
                case KnownChampion.Ezreal:
                    result = new ChampionDescription(champion,
                        "",
                        RoleTag.Marksmen,
                        RegionTag.Piltover,
                        new HashSet<PerkTag> { PerkTag.Global },
                        new HashSet<SkinTag> { SkinTag.Debonair, SkinTag.Cards },
                        null);
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}