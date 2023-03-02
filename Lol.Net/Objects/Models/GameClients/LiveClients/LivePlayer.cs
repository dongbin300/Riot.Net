using Lol.Net.Objects.Models.LolModels;

namespace Lol.Net.Objects.Models.GameClients.LiveClients
{
    public record LivePlayer(string championName, bool isBot, bool isDead, IEnumerable<LolLiveItem> items, int level, string position, string rawChampionName, string rawSkinName, decimal respawnTimer, LolRune runes, LolScore scores, int skinID, string skinName, string summonerName, LolShortSummonerSpells summonerSpells, string team);
}
