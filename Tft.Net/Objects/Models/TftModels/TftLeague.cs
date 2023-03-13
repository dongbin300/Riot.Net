namespace Tft.Net.Objects.Models.TftModels
{
    public record TftLeagueList(string leagueId, IEnumerable<TftLeagueItem> entries, string tier, string name, string queue);

    public record TftLeagueItem(bool freshBlood, int wins, string summonerName, TftLeagueMiniSeries miniSeries, bool inactive, bool veteran, bool hotStreak, string rank, int leaguePoints, int losses, string summonerId);

    public record TftLeagueMiniSeries(int losses, string progress, int target, int wins);

    public record TftLeagueEntry(string leagueId, string summonerId, string summonerName, string queueType, string ratedTier, int ratedRating, string tier, string rank, int leaguePoints, int wins, int losses, bool hotStreak, bool veteran, bool freshBlood, bool inactive, TftLeagueMiniSeries miniSeries);

    public record TftLeagueTopRatedLadderEntry(string summonerId, string summonerName, string ratedTier, int ratedRating, int wins, int previousUpdateLadderPosition);
}
