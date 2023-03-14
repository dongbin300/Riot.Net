namespace Val.Net.Objects.Models.ValModels
{
    public record ValRankedLeaderboard(string shard, string actId, long totalPlayers, IEnumerable<ValRankedPlayer> players);

    public record ValRankedPlayer(string puuid, string gameName, string tagLine, long leaderboardRank, long rankedRating, long numberOfWins);
}
