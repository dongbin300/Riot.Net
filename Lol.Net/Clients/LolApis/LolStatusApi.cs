using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolStatusApi : ApiClient
    {
        public LolStatusApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<LolStatusPlatformData> GetStatusAsync()
        {
            return await GetAsync<LolStatusPlatformData>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/status/v4/platform-data?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}