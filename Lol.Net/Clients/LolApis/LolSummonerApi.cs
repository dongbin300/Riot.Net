using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolSummonerApi : ApiClient
    {
        public LolSummonerApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<LolSummoner> GetSummonerByNameAsync(string summonerName)
        {
            return await GetAsync<LolSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/summoner/v4/summoners/by-name/{summonerName}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolSummoner> GetSummonerByAccountIdAsync(string accountId)
        {
            return await GetAsync<LolSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/summoner/v4/summoners/by-account/{accountId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolSummoner> GetSummonerByPuuIdAsync(string puuId)
        {
            return await GetAsync<LolSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/{puuId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolSummoner> GetSummonerBySummonerIdAsync(string summonerId)
        {
            return await GetAsync<LolSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/summoner/v4/summoners/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}