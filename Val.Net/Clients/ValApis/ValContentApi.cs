using Val.Net.Enums;
using Val.Net.Objects.Models.ValModels;

namespace Val.Net.Clients.ValApis
{
    public class ValContentApi : ValApiClient
    {
        public ValContentApi(HttpClient client, string apiKey, ValRegion defaultValRegion) : base(client, apiKey, defaultValRegion)
        {
            this.apiKey = apiKey;
            this.defaultValRegion = defaultValRegion;
        }

        public async Task<ValContent> GetContentOptionallyByLocaleAsync(string locale = "")
        {
            return await GetAsync<ValContent>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/content/v1/contents?locale={locale}&api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
