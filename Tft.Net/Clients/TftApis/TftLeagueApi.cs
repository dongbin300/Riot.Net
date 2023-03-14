using Riot.Net.Clients;
using Riot.Net.Enums;
using Riot.Net.Extensions;

using Tft.Net.Objects.Models.TftModels;

namespace Tft.Net.Clients.TftApis
{
    public class TftLeagueApi : ApiClient
    {
        public TftLeagueApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<TftLeagueList> GetChallengerLeagueAsync()
        {
            return await GetAsync<TftLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/challenger?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<TftLeagueEntry>> GetLeagueEntriesBySummonerIdAsync(string summonerId)
        {
            return await GetAsync<IEnumerable<TftLeagueEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/entries/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<TftLeagueEntry>> GetAllLeagueEntriesAsync(Tier tier, Division division)
        {
            return await GetAsync<IEnumerable<TftLeagueEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/entries/{tier.ToUrlString()}/{division.ToUrlString()}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftLeagueList> GetGrandMasterLeagueAsync()
        {
            return await GetAsync<TftLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/grandmaster?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftLeagueList> GetLeagueByLeagueIdAsync(string leagueId)
        {
            return await GetAsync<TftLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/leagues/{leagueId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftLeagueList> GetMasterLeagueAsync()
        {
            return await GetAsync<TftLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/master?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<TftLeagueTopRatedLadderEntry>> GetTopRatedLadderAsync(Queue queue)
        {
            return await GetAsync<IEnumerable<TftLeagueTopRatedLadderEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/league/v1/rated-ladders/{queue.ToUrlString()}/top?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
