using Val.Net.Enums;
using Val.Net.Objects.Models.ValModels;

namespace Val.Net.Clients.ValApis
{
    public class ValRankedApi : ValApiClient
    {
        public ValRankedApi(HttpClient client, string apiKey, ValRegion defaultValRegion) : base(client, apiKey, defaultValRegion)
        {
            this.apiKey = apiKey;
            this.defaultValRegion = defaultValRegion;
        }

        public async Task<ValRankedLeaderboard> GetLeaderboardAsync(string actId, int size = 200, int startIndex = 0)
        {
            return await GetAsync<ValRankedLeaderboard>(Client, $"https://{defaultValRegion}.api.riotgames.com/val/ranked/v1/leaderboards/by-act/{actId}?size={size}&startIndex={startIndex}&api_key={apiKey}").ConfigureAwait(false);
        }
    }
}
