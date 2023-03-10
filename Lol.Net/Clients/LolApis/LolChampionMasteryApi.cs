using Lol.Net.Enums;
using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolChampionMasteryApi : ApiClient
    {
        public LolChampionMasteryApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<LolChampionMastery>> GetAllChampionMasteryAsync(string summonerId)
        {
            return await GetAsync<IEnumerable<LolChampionMastery>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolChampionMastery> GetChampionMasteryByChampionIdAsync(string summonerId, string championId)
        {
            return await GetAsync<LolChampionMastery>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summonerId}/by-champion/{championId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolChampionMastery>> GetTopChampionMasteryAsync(string summonerId)
        {
            return await GetAsync<IEnumerable<LolChampionMastery>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summonerId}/top?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<int> GetTotalChampionMasteryScoreAsync(string summonerId)
        {
            return await GetAsync<int>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/champion-mastery/v4/scores/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}