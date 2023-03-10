using Lol.Net.Enums;
using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.LolApis
{
    public class LolLeagueApi : ApiClient
    {
        public LolLeagueApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<LolLeagueList> GetChallengerLeagueByQueueAsync(Queue queue)
        {
            return await GetAsync<LolLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/challengerleagues/by-queue/{queue.ToUrlString()}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolLeagueEntry>> GetAllQueuesBySummonerIdAsync(string summonerId)
        {
            return await GetAsync<IEnumerable<LolLeagueEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/entries/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolLeagueEntry>> GetAllLeagueEntriesAsync(Queue queue, Tier tier, Division division, int page = 1)
        {
            return await GetAsync<IEnumerable<LolLeagueEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/entries/{queue.ToUrlString()}/{tier.ToUrlString()}/{division.ToUrlString()}?page={page}&api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolLeagueList> GetGrandmasterLeagueByQueueAsync(Queue queue)
        {
            return await GetAsync<LolLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/grandmasterleagues/by-queue/{queue.ToUrlString()}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolLeagueList> GetLeagueByLeagueIdAsync(string leagueId)
        {
            return await GetAsync<LolLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/leagues/{leagueId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolLeagueList> GetMasterLeagueByQueueAsync(Queue queue)
        {
            return await GetAsync<LolLeagueList>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league/v4/masterleagues/by-queue/{queue.ToUrlString()}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}