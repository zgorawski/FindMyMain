using System;

public enum KnownChampion
{
    Aatrox = 266,
    Thresh = 412,
    Tryndamere = 23,
    Gragas = 79,
    AurelionSol = 136,
    Cassiopeia = 69,
    Poppy = 78,
    Ryze = 13,
    Sion = 14,
    Annie = 1,
    Jhin = 202,
    Nautilus = 111,
    Karma = 43,
    Lux = 99,
    Ahri = 103,
    Olaf = 2,
    Viktor = 112,
    Singed = 27,
    Garen = 86,
    Anivia = 34,
    Maokai = 57,
    Lissandra = 127,
    Morgana = 25,
    Evelynn = 28,
    Fizz = 105,
    Heimerdinger = 74,
    Zed = 238,
    Rumble = 68,
    Mordekaiser = 82,
    Sona = 37,
    Katarina = 55,
    KogMaw = 96,
    Ashe = 22,
    Lulu = 117,
    Karthus = 30,
    Alistar = 12,
    Darius = 122,
    Vayne = 67,
    Udyr = 77,
    Varus = 110,
    Jayce = 126,
    Leona = 89,
    Syndra = 134,
    Pantheon = 80,
    Khazix = 121,
    Riven = 92,
    Corki = 42,
    Caitlyn = 51,
    Azir = 268,
    Nidalee = 76,
    Kennen = 85,
    Galio = 3,
    Veigar = 45,
    Bard = 432,
    Gnar = 150,
    Malzahar = 90,
    Graves = 104,
    Vi = 254,
    Kayle = 10,
    Irelia = 39,
    LeeSin = 64,
    Illaoi = 420,
    Elise = 60,
    Volibear = 106,
    Nunu = 20,
    TwistedFate = 4,
    Jax = 24,
    Shyvana = 102,
    Kalista = 429,
    DrMundo = 36,
    TahmKench = 223,
    Diana = 131,
    Brand = 63,
    Sejuani = 113,
    Vladimir = 8,
    Zac = 154,
    RekSai = 421,
    Quinn = 133,
    Akali = 84,
    Tristana = 18,
    Hecarim = 120,
    Sivir = 15,
    Lucian = 236,
    Rengar = 107,
    Warwick = 19,
    Skarner = 72,
    Malphite = 54,
    Yasuo = 157,
    Xerath = 101,
    Teemo = 17,
    Renekton = 58,
    Nasus = 75,
    Draven = 119,
    Shaco = 35,
    Swain = 50,
    Janna = 40,
    Talon = 91,
    Ziggs = 115,
    Ekko = 245,
    Orianna = 61,
    FiddleSticks = 9,
    Fiora = 114,
    Chogath = 31,
    Rammus = 33,
    Leblanc = 7,
    Soraka = 16,
    Zilean = 26,
    Nocturne = 56,
    Jinx = 222,
    Yorick = 83,
    Urgot = 6,
    Kindred = 203,
    MissFortune = 21,
    MonkeyKing = 62,
    Blitzcrank = 53,
    Shen = 98,
    Braum = 201,
    XinZhao = 5,
    Twitch = 29,
    MasterYi = 11,
    Taric = 44,
    Amumu = 32,
    Gangplank = 41,
    Trundle = 48,
    Kassadin = 38,
    Velkoz = 161,
    Zyra = 143,
    Nami = 267,
    JarvanIV = 59,
    Ezreal = 81
}

public class KnownChampionUtility
{
    public static string ChampionIdToName(int championId)
    {
        if (!Enum.IsDefined(typeof(KnownChampion), championId)) { return string.Empty;  }

        var champion = (KnownChampion)championId;
        string result = string.Empty;

        switch (champion)
        {
            case KnownChampion.AurelionSol:
                result = "Aurelion Sol";
                break;
            case KnownChampion.KogMaw:
                result = "Kog'Maw";
                break;
            case KnownChampion.Khazix:
                result = "Kha'Zix";
                break;
            case KnownChampion.LeeSin:
                result = "Lee Sin";
                break;
            case KnownChampion.TwistedFate:
                result = "Twisted Fate";
                break;
            case KnownChampion.DrMundo:
                result = "Dr Mundo";
                break;
            case KnownChampion.TahmKench:
                result = "Tahm Kench";
                break;
            case KnownChampion.RekSai:
                result = "Rek'Sai";
                break;
            case KnownChampion.MissFortune:
                result = "Miss Fortune";
                break;
            case KnownChampion.MonkeyKing:
                result = "Wukong";
                break;
            case KnownChampion.XinZhao:
                result = "Xin Zhao";
                break;
            case KnownChampion.MasterYi:
                result = "Master Yi";
                break;
            case KnownChampion.Velkoz:
                result = "Vel'Koz";
                break;
            case KnownChampion.JarvanIV:
                result = "Jarvan IV";
                break;
            default:
                result = Enum.GetName(typeof(KnownChampion), champion);
                break;
        }
        
        return result;
    }
}