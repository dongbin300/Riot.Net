using Lol.Net.Enums;
using Lol.Net.Objects.Models;
using Lol.Net.Objects.Models.DataDragons;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lol.Net.Applications.DataDragons
{
    public class OtherDataDragon
    {
        private readonly HttpClient client;

        public OtherDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Response<DataDragonSummonerSpells>> GetSummonerSpellsAsync(string version, LanguageEnum language)
        {
            return await BaseApplication.RequestAsync<Response<DataDragonSummonerSpells>>(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/data/{language.Id}/summoner.json").ConfigureAwait(false);
        }

        public async Task<byte[]> GetSummonerSpellAssetsAsync(string spellId, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/spell/{spellId}.png").ConfigureAwait(false);
        }

        public async Task<IDictionary<string, LolProfileIcon?>> GetProfileIconsAsync(string version, LanguageEnum language)
        {
            var result = await BaseApplication.RequestAsync<Response<object>>(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/data/{language.Id}/profileicon.json").ConfigureAwait(false);

            if (result == null)
            {
                return default!;
            }

            var data = (JObject)result.data;
            var profileIcons = new Dictionary<string, LolProfileIcon?>();
            foreach (var x in data)
            {
                if (x.Value == null)
                {
                    continue;
                }

                string key = x.Key;
                var value = JsonConvert.DeserializeObject<LolProfileIcon>(x.Value.ToString());
                profileIcons.Add(key, value);
            }

            return profileIcons;
        }

        public async Task<byte[]> GetProfileIconAssetsAsync(string profileIconId, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/profileicon/{profileIconId}.png").ConfigureAwait(false);
        }

        public async Task<byte[]> GetMinimapAssetsAsync(string mapName, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/map/{mapName}.png").ConfigureAwait(false);
        }

        public async Task<byte[]> GetSpriteAssetsAsync(string spellName, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/sprite/{spellName}.png").ConfigureAwait(false);
        }

        public async Task<byte[]> GetScoreboardIconAssetsAsync(string name, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, $"http://ddragon.leagueoflegends.com/cdn/{version}/img/ui/{name}.png").ConfigureAwait(false);
        }
    }
}
