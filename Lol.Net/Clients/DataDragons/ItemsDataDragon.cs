using Lol.Net.Objects;
using Lol.Net.Objects.Models.DataDragons;
using Lol.Net.Objects.Models.LolModels;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Riot.Net.Clients;
using Riot.Net.Enums;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class ItemsDataDragon : BaseClient
    {
        public ItemsDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task<DataDragonItems> GetItemsAsync(string version, LanguageEnum language)
        {
            var result = await GetAsync<object>(Client, LolApiAddresses.DataDragonAddress.CombineUri(version, "data", language.Id, "item.json")).ConfigureAwait(false);

            if (result == null)
            {
                return default!;
            }

            var obj = (JObject)result;
            var type = obj.Value<string>("type") ?? string.Empty;
            var _version = obj.Value<string>("version") ?? string.Empty;
            var basic = JsonConvert.DeserializeObject<Basic>(obj.Value<string>("basic") ?? string.Empty) ?? default!;
            var groups = JsonConvert.DeserializeObject<IEnumerable<DataDragonItems_Group>>(obj.Value<string>("groups") ?? string.Empty) ?? default!;
            var tree = JsonConvert.DeserializeObject<IEnumerable<DataDragonItems_Tree>>(obj.Value<string>("tree") ?? string.Empty) ?? default!;
            var data = obj.Value<JObject>("data") ?? default!;

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
            return await GetBytesAsync(Client, LolApiAddresses.DataDragonAddress.CombineUri(version, "img", "item", itemId + ".png")).ConfigureAwait(false);
        }
    }
}
