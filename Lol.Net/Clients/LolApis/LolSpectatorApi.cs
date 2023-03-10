using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolSpectatorApi : ApiClient
    {
        public LolSpectatorApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<LolCurrentGame> GetCurrentGameInfoAsync(string summonerId)
        {
            return await GetAsync<LolCurrentGame>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/spectator/v4/active-games/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolFeaturedGames> GetFeaturedGamesAsync(string summonerId)
        {
            return await GetAsync<LolFeaturedGames>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/spectator/v4/active-games/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}