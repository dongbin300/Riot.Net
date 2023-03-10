namespace Lol.Net.Objects.Models.LolModels
{
    public record LolChampionInfo(int maxNewPlayerLevel, IEnumerable<int> freeChampionIdsForNewPlayers, IEnumerable<int> freeChampionIds);
}
