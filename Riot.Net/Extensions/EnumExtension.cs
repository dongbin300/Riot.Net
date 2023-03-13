using Riot.Net.Enums;

namespace Riot.Net.Extensions
{
    public static class EnumExtension
    {
        public static string ToUrlString(this PlatformRouting platformRouting) => platformRouting.ToString().ToLower();
        public static string ToUrlString(this RegionalRouting regionalRouting) => regionalRouting.ToString().ToLower();
        public static string ToUrlString(this Division division) => division.ToString();
        public static string ToUrlString(this Tier tier) => tier.ToString();
        public static string ToUrlString(this Queue queue) => queue switch
        {
            Queue.UnrankedSolo55 => "UNRANKED_SOLO_5x5",
            Queue.UnrankedTeam55 => "UNRANKED_TEAM_5x5",
            Queue.RankedSolo55 => "RANKED_SOLO_5x5",
            Queue.RankedTeam55 => "RANKED_TEAM_5x5",
            Queue.RankedFlexSr => "RANKED_FLEX_SR",
            Queue.RankedFlexTt => "RANKED_FLEX_TT",
            Queue.RankedTft => "RANKED_TFT",
            Queue.RankedTftTurbo => "RANKED_TFT_TURBO",
            _ => ""
        };
    }
}
