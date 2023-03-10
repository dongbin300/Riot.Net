namespace Lol.Net.Objects.Models.LolModels
{
    public record LolLeagueList(string leagueId, IEnumerable<LolLeagueItem> entries, string tier, string name, string queue);

    public record LolLeagueItem(bool freshBlood, int wins, string summonerName, LolLeagueMiniSeries miniSeries, bool inactive, bool veteran, bool hotStreak, string rank, int leaguePoints, int losses, string summonerId);

    public record LolLeagueEntry(string leagueId, string summonerId, string summonerName, string queueType, string tier, string rank, int leaguePoints, int wins, int losses, bool hotStreak, bool veteran, bool freshBlood, bool inactive, LolLeagueMiniSeries miniSeries);

    public record LolLeagueMiniSeries(int losses, string progress, int target, int wins);
}
