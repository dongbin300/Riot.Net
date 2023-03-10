using Lol.Net.Enums;
using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.LolApis
{
    public class LolLeagueExpApi : ApiClient
    {
        public LolLeagueExpApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<LolLeagueEntry>> GetAllLeagueEntriesAsync(Queue queue, Tier tier, Division division, int page = 1)
        {
            return await GetAsync<IEnumerable<LolLeagueEntry>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/league-exp/v4/entries/{queue.ToUrlString()}/{tier.ToUrlString()}/{division.ToUrlString()}?page={page}&api_key={apiKey}").ConfigureAwait(false);
        }
    }
}