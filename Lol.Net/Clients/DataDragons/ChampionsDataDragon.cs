using Lol.Net.Enums;
using Lol.Net.Objects;
using Lol.Net.Objects.Models;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class ChampionsDataDragon : BaseClient
    {
        public ChampionsDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task<IDictionary<string, Objects.Models.LolModels.Champion?>> GetChampionsAsync(string version, LanguageEnum language)
        {
            var result = await GetAsync<Response<object>>(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "data", language.Id, "champion.json")).ConfigureAwait(false);

            if (result == null)
            {
                return default!;
            }

            var data = (JObject)result.data;
            var champions = new Dictionary<string, Objects.Models.LolModels.Champion?>();
            foreach (var x in data)
            {
                if (x.Value == null)
                {
                    continue;
                }

                string key = x.Key;
                var value = JsonConvert.DeserializeObject<Objects.Models.LolModels.Champion>(x.Value.ToString());
                champions.Add(key, value);
            }

            return champions;
        }

        public async Task<IDictionary<string, ChampionDetail?>> GetChampionDetailAsync(Enums.Champion champion, string version, LanguageEnum language)
        {
            var result = await GetAsync<Response<object>>(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "data", language.Id, "champion", champion.ToString() + ".json")).ConfigureAwait(false);

            if (result == null)
            {
                return default!;
            }

            var data = (JObject)result.data;
            var champions = new Dictionary<string, ChampionDetail?>();
            foreach (var x in data)
            {
                if (x.Value == null)
                {
                    continue;
                }

                string key = x.Key;
                var value = JsonConvert.DeserializeObject<ChampionDetail>(x.Value.ToString());
                champions.Add(key, value);
            }

            return champions;
        }

        public async Task<byte[]> GetChampionSplashAssetsAsync(Enums.Champion champion, int skinNum)
        {
            return await GetBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri("img", "champion", "splash", champion.ToString() + "_" + skinNum.ToString() + ".jpg")).ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionLoadingScreenAssetsAsync(Enums.Champion champion, int skinNum)
        {
            return await GetBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri("img", "champion", "loading", champion.ToString() + "_" + skinNum.ToString() + ".jpg")).ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionSquareAssetsAsync(Enums.Champion champion, string version)
        {
            return await GetBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "img", "champion", champion.ToString() + ".png")).ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionPassiveAssetsAsync(string passiveImageName, string version)
        {
            return await GetBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "img", "passive", passiveImageName + ".png")).ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionAbilityAssetsAsync(string abilityName, string version)
        {
            return await GetBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "img", "spell", abilityName + ".png")).ConfigureAwait(false);
        }
    }
}