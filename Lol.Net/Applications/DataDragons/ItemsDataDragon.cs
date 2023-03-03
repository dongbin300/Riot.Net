using Lol.Net.Enums;
using Lol.Net.Objects;
using Lol.Net.Objects.Models.DataDragons;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Riot.Net.Extensions;

namespace Lol.Net.Applications.DataDragons
{
    public class ItemsDataDragon
    {
        private readonly HttpClient client;

        public ItemsDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<DataDragonItems> GetItemsAsync(string version, LanguageEnum language)
        {
            var result = await BaseApplication.RequestAsync<object>(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "data", language.Id, "item.json")).ConfigureAwait(false);

            if (result == null)
            {
                return default!;
            }

            var obj = (JObject)result;
            var type = obj["type"].ToString();
            var _version = obj["version"].ToString();
            var basic = JsonConvert.DeserializeObject<Basic>(obj["basic"].ToString());
            var groups = JsonConvert.DeserializeObject<IEnumerable<DataDragonItems_Group>>(obj["groups"].ToString());
            var tree = JsonConvert.DeserializeObject<IEnumerable<DataDragonItems_Tree>>(obj["tree"].ToString());
            var data = (JObject)obj["data"];

            var items = new Dictionary<string, LolItem?>();
            foreach (var x in data)
            {
                if (x.Value == null)
                {
                    continue;
                }

                var key = x.Key;
                var value = JsonConvert.DeserializeObject<LolItem>(x.Value.ToString());
                items.Add(key, value);
            }

            return new DataDragonItems(type, _version, basic, items, groups, tree);
        }

        public async Task<byte[]> GetItemAssetsAsync(string itemId, string version)
        {
            return await BaseApplication.RequestBytesAsync(client, LolApiAddresses.DataDragonAddress.CombineUri(version, "img", "item", itemId, ".png")).ConfigureAwait(false);
        }
    }
}
