using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolChampionApi : ApiClient
    {
        public LolChampionApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<LolChampionInfo> GetChampionRotationsAsync()
        {
            return await GetAsync<LolChampionInfo>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/platform/v3/champion-rotations?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}