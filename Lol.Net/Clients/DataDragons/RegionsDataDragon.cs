using Lol.Net.Objects;
using Lol.Net.Objects.Models.DataDragons;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class RegionsDataDragon : BaseClient
    {
        public RegionsDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task<DataDragonRegions> GetRegionsAsync()
        {
            return await GetAsync<DataDragonRegions>(Client, LolApiAddresses.DataDragonBaseAddress.CombineUri("realms", "na.json")).ConfigureAwait(false);
        }
    }
}
