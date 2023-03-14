using Val.Net.Enums;
using Val.Net.Objects.Models.ValModels;

namespace Val.Net.Clients.ValApis
{
    public class ValStatusApi : ValApiClient
    {
        public ValStatusApi(HttpClient client, string apiKey, ValRegion defaultValRegion) : base(client, apiKey, defaultValRegion)
        {
            this.apiKey = apiKey;
            this.defaultValRegion = defaultValRegion;
        }

        public async Task<ValStatusPlatformData> GetStatusAsync()
        {
            return await GetAsync<ValStatusPlatformData>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/status/v1/platform-data?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
