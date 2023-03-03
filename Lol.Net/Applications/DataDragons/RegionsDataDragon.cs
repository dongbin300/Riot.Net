using Lol.Net.Objects;
using Lol.Net.Objects.Models.DataDragons;

using Riot.Net.Extensions;

namespace Lol.Net.Applications.DataDragons
{
    public class RegionsDataDragon
    {
        private readonly HttpClient client;

        public RegionsDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<DataDragonRegions> GetRegionsAsync()
        {
            return await BaseApplication.RequestAsync<DataDragonRegions>(client, LolApiAddresses.DataDragonBaseAddress.CombineUri("realms", "na.json")).ConfigureAwait(false);
        }
    }
}
