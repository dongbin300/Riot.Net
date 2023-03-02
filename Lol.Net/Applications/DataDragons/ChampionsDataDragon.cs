using Lol.Net.Enums;
using Lol.Net.Objects.Models;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lol.Net.Applications.DataDragons
{
    public class ChampionsDataDragon
    {
        private readonly HttpClient client;

        public ChampionsDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IDictionary<string, Objects.Models.LolModels.Champion?>> GetChampionsAsync(string version, LanguageEnum language)
        {
            var result = await BaseApplication.RequestAsync<Response<object>>(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/data/{language.Id}/champion.json").ConfigureAwait(false);

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
            var result = await BaseApplication.RequestAsync<Response<object>>(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/data/{language.Id}/champion/{champion}.json").ConfigureAwait(false);

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
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/img/champion/splash/{champion}_{skinNum}.jpg").ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionLoadingScreenAssetsAsync(Enums.Champion champion, int skinNum)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/img/champion/loading/{champion}_{skinNum}.jpg").ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionSquareAssetsAsync(Enums.Champion champion, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/champion/{champion}.png").ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionPassiveAssetsAsync(string passiveImageName, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/passive/{passiveImageName}.png").ConfigureAwait(false);
        }

        public async Task<byte[]> GetChampionAbilityAssetsAsync(string abilityName, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/spell/{abilityName}.png").ConfigureAwait(false);
        }
    }
}