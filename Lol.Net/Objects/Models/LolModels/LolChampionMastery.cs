namespace Lol.Net.Objects.Models.LolModels
{
    public record LolChampionMastery(long championPointsUntilNextLevel, bool chestGranted, long championId, long lastPlayTime, int championLevel, string summonerId, int championPoints, long championPointsSinceLastLevel, int tokensEarned);
}
