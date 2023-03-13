using Riot.Net.Clients;
using Riot.Net.Enums;

using System.Text.RegularExpressions;

using Tft.Net.Objects.Models.TftModels;

namespace Tft.Net.Clients.TftApis
{
    public class TftMatchApi : ApiClient
    {
        public TftMatchApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting, RegionalRouting defaultRegionalRouting) : base(client, apiKey, defaultPlatformRouting, defaultRegionalRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
            this.defaultRegionalRouting = defaultRegionalRouting;
        }

        public async Task<IEnumerable<string>> GetMatchIdsByPuuIdAsync(string puuId)
        {
            return await GetAsync<IEnumerable<string>>(Client, $"https://{defaultRegionalRouting}.api.riotgames.com/tft/match/v1/matches/by-puuid/{puuId}/ids?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftMatch> GetMatchByMatchIdAsync(string matchId)
        {
            return await GetAsync<TftMatch>(Client, $"https://{defaultRegionalRouting}.api.riotgames.com/tft/match/v1/matches/{matchId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
