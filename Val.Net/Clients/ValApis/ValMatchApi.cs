using System;

using Val.Net.Enums;
using Val.Net.Objects.Models.ValModels;

namespace Val.Net.Clients.ValApis
{
    public class ValMatchApi : ValApiClient
    {
        public ValMatchApi(HttpClient client, string apiKey, ValRegion defaultValRegion) : base(client, apiKey, defaultValRegion)
        {
            this.apiKey = apiKey;
            this.defaultValRegion = defaultValRegion;
        }

        public async Task<ValMatch> GatMatchByMatchIdAsync(string matchId)
        {
            return await GetAsync<ValMatch>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/match/v1/matches/{matchId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<ValMatchlist> GatMatchlistByPuuIdAsync(string puuId)
        {
            return await GetAsync<ValMatchlist>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/match/v1/matchlists/by-puuid/{puuId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<ValRecentMatches> GatRecentMatchesAsync(ValQueue queue)
        {
            return await GetAsync<ValRecentMatches>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/match/v1/recent-matches/by-queue/{queue}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
