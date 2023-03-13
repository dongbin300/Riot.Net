using Lol.Net.Objects.Models;
using Lol.Net.Objects;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json.Linq;

using Newtonsoft.Json;

using Riot.Net.Clients;
using Riot.Net.Enums;

using System;

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

        public async Task<LolChallengeLevelToPercentile> GetAllLevelToPercentilesOfPlayersAsync()
        {
            var result = await GetAsync<JObject>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/percentiles?api_key={apiKey}").ConfigureAwait(false) ?? default!;

            var percentiles = new Dictionary<string, LolChallengePercentile>();
            foreach (var x in result)
            {
                if (x.Value == null)
                {
                    continue;
                }

                string key = x.Key;
                var value = JsonConvert.DeserializeObject<LolChallengePercentile>(x.Value.ToString()) ?? default!;
                percentiles.Add(key, value);
            }

            return new LolChallengeLevelToPercentile(percentiles);
        }

        public async Task<LolChallengeConfig> GetChallengeConfigAsync(long challengeId)
        {
            return await GetAsync<LolChallengeConfig>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/config?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolChallengeApexPlayer>> GetTopPlayersByLevelAsync(long challengeId, string level)
        {
            return await GetAsync<IEnumerable<LolChallengeApexPlayer>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/leaderboards/by-level/{level}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IDictionary<string, decimal>> GetLevelToPercentilesAsync(long challengeId)
        {
            return await GetAsync<IDictionary<string, decimal>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/challenges/{challengeId}/percentiles?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolChallengePlayer> GetPlayerInfoAsync(string puuid)
        {
            return await GetAsync<LolChallengePlayer>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/challenges/v1/player-data/{puuid}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}