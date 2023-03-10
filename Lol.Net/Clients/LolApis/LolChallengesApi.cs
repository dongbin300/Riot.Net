using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolChallengesApi : ApiClient
    {
        public LolChallengesApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<LolChallengeConfig>> GetAllBasicChallengeConfigInfoAsync()
        {
            return await GetAsync<IEnumerable<LolChallengeConfig>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/config?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IDictionary<long, IDictionary<int, IDictionary<object, decimal>>>> GetAllLevelToPercentilesOfPlayersAsync()
        {
            return await GetAsync<IDictionary<long, IDictionary<int, IDictionary<object, decimal>>>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/percentiles?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolChallengeConfig> GetChallengeConfigAsync(long challengeId)
        {
            return await GetAsync<LolChallengeConfig>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/config?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolChallengeApexPlayer>> GetTopPlayersByLevelAsync(long challengeId, string level)
        {
            return await GetAsync<IEnumerable<LolChallengeApexPlayer>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/leaderboards/by-level/{level}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IDictionary<object, decimal>> GetLevelToPercentilesAsync(long challengeId)
        {
            return await GetAsync<IDictionary<object, decimal>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/percentiles?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolChallengePlayer> GetPlayerInfoAsync(string puuid)
        {
            return await GetAsync<LolChallengePlayer>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/player-data/{puuid}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}