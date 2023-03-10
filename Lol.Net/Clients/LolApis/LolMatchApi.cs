using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolMatchApi : ApiClient
    {
        public LolMatchApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<string>> GetMatchIdsByPuuIdAsync(string puuId, int start = 0, int count = 20)
        {
            return await GetAsync<IEnumerable<string>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuId}/ids?start={start}&count={count}&api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolMatch> GetMatchByMatchIdAsync(string matchId)
        {
            return await GetAsync<LolMatch>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/match/v5/matches/{matchId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolMatchTimeline> GetMatchTimelineByMatchIdAsync(string matchId)
        {
            return await GetAsync<LolMatchTimeline>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}