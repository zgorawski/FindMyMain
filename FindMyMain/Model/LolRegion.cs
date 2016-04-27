using System;
using System.Collections.Generic;
using System.Linq;

public enum Region
{
    // PBE is omited
    BR, EUNE, EUW, JP, KR, LAN, LAS, NA, OCE, RU, TR
}

public class RegionUtility
{
    public static IEnumerable<Region> AllRegions()
    {
        return Enum.GetValues(typeof(Region)).Cast<Region>();
    }

    public static string regionToString(Region region)
    {
        var stringifiedRegion = Enum.GetName(typeof(Region), region);
        return stringifiedRegion.ToLower();
    }

    public static string regionToPlatformId(Region region)
    {
        switch (region)
        {
            case Region.BR:
                return "BR1";
            case Region.EUNE:
                return "EUN1";
            case Region.EUW:
                return "EUW1";
            case Region.JP:
                return "JP1";
            case Region.KR:
                return "KR";
            case Region.LAN:
                return "LA1";
            case Region.LAS:
                return "LA2";
            case Region.NA:
                return "NA1";
            case Region.OCE:
                return "OC1";
            case Region.RU:
                return "RU";
            case Region.TR:
                return "TR1";
            default:
                return null;
        }
    }
}