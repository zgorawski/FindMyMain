using System;

public enum RoleTag
{
    Tank, Fighter, Slayer, Mage, Controller, Marksmen
}

public enum RegionTag
{
    BandleCity, Bilgewater, Damacia, Freljord, Ionia, MountTargon, Noxus, Piltover, ShadowIsles, Shurima, Zaun, Void, Other
}

public enum PerkTag
{
    Animal, Shapeshifter, PetChampion, HealthCostAbilities, Global, Yordle
}

public enum SkinTag
{
    HighNoon, Victorious, ChineseNewYear, Sweetheart, SnowDay, PoolParty, Hearthseeker, GuardianOfTheSands, Pentakill, SuperGalaxy,
    Mafia, Arcade, RiotSquad, Warden, Vandal, Battlecast, Commando, Dragonslayer, Project, Hextech, Officer, Headhunter, Mecha,
    Championship, BloodMoon, WarringKingdoms, Christmas, School, Pirate, Debonair, Cards, OrderOfLotus,
    SteelLegion, Academy, Marauder, Haunted, Program, DefinitelyNot, Arclight, Medical
}

class RegionTagUtility
{
    public static string Stringify(RegionTag region)
    { 
        string result = string.Empty;

        switch (region)
        {
            case RegionTag.BandleCity:
                result = "Bandle City";
                break;
            case RegionTag.MountTargon:
                result = "Mount Targon";
                break;
            case RegionTag.ShadowIsles:
                result = "Shadow Isles";
                break;
            default:
                result = Enum.GetName(typeof(RegionTag), region);
                break;
        }

        return result;
    }
}

class SkinTagUtility
{
    public static string Stringify(SkinTag skin)
    {
        string result = string.Empty;

        switch (skin)
        {
            case SkinTag.HighNoon:
                result = "a High Noon";
                break;
            case SkinTag.ChineseNewYear:
                result = "a Chinese New Year";
                break;
            case SkinTag.SnowDay:
                result = "a Snow Day";
                break;
            case SkinTag.PoolParty:
                result = "a Pool Party";
                break;
            case SkinTag.GuardianOfTheSands:
                result = "a Guardian Of The Sands";
                break;
            case SkinTag.SuperGalaxy:
                result = "a Super Galaxy";
                break;
            case SkinTag.Arcade:
                result = "an Arcade";
                break;
            case SkinTag.RiotSquad:
                result = "a Riot Squad";
                break;
            case SkinTag.Project:
                result = "a PROJECT";
                break;
            case SkinTag.Officer:
                result = "a Police Officer";
                break;
            case SkinTag.BloodMoon:
                result = "a Blood Moon";
                break;
            case SkinTag.WarringKingdoms:
                result = "a Warring Kingdoms";
                break;
            case SkinTag.Cards:
                result = "a Cards inspired";
                break;
            case SkinTag.OrderOfLotus:
                result = "an Order O fLotus";
                break;
            case SkinTag.SteelLegion:
                result = "an Steel Legion";
                break;
            case SkinTag.Academy:
                result = "an Academy";
                break;
            case SkinTag.DefinitelyNot:
                result = "a totally not suspicious";
                break;
            case SkinTag.Arclight:
                result = "an Arclight";
                break;
            default:
                result = "a " + Enum.GetName(typeof(SkinTag), skin);
                break;
        }

        return result;
    }
}