using Lol.Net.Objects.Models.LolModels;

namespace Lol.Net.Objects.Models.GameClients.LiveClients
{
    public record ActivePlayer(LolAbilities abilities, LiveChampionStats championStats, decimal currentGold, LolFullRune fullRunes, int level, string summonerName, bool teamRelativeColors);
}
