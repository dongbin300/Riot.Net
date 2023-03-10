namespace Lol.Net.Objects.Models.LolModels
{
    public record LolChallenge();

    public record LolChallengeConfig(long id, IDictionary<string, IDictionary<string, string>> localizedNames, string state, string tracking, long startTimestamp, long endTimestamp, bool leaderboard, IDictionary<string, decimal> thresholds);

    public record LolChallengeApexPlayer(string puuid, decimal value, int position);

    public record LolChallengePlayer(IEnumerable<LolChallengeInfo> challenges, LolChallengePlayerClientPreferences preferences, LolChallengePoints totalPoints, IDictionary<string, LolChallengePoints> categoryPoints);

    public record LolChallengeInfo(long challengeId, decimal percentile, string level, decimal value, long achievedTime, long position, long playersInLevel);

    public record LolChallengePlayerClientPreferences(string bannerAccent, string title, IEnumerable<long> challengeIds);

    public record LolChallengePoints(string level, long current, long max, decimal percentile);
}
