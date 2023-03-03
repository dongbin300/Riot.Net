using Lol.Net.Objects;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class VersionsDataDragon : BaseClient
    {
        public VersionsDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task<IEnumerable<string>> GetVersionsAsync()
        {
            return await GetAsync<IEnumerable<string>>(client, LolApiAddresses.DataDragonBaseAddress.CombineUri("api", "versions.json")).ConfigureAwait(false);
        }
    }
}
