using Riot.Net.Clients;
using Riot.Net.Enums;

using Tft.Net.Objects.Models.TftModels;

namespace Tft.Net.Clients.TftApis
{
    public class TftSummonerApi : ApiClient
    {
        public TftSummonerApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<TftSummoner> GetSummonerByAccountIdAsync(string accountId)
        {
            return await GetAsync<TftSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/summoner/v1/summoners/by-account/{accountId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftSummoner> GetSummonerBySummonerNameAsync(string summonerName)
        {
            return await GetAsync<TftSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/summoner/v1/summoners/by-name/{summonerName}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftSummoner> GetSummonerByPuuIdAsync(string puuId)
        {
            return await GetAsync<TftSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/summoner/v1/summoners/by-puuid/{puuId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<TftSummoner> GetSummonerBySummonerIdAsync(string summonerId)
        {
            return await GetAsync<TftSummoner>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/tft/summoner/v1/summoners/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
