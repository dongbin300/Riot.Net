using Lol.Net.Objects;

using Riot.Net.Extensions;

namespace Lol.Net.Applications.DataDragons
{
    public class VersionsDataDragon
    {
        private readonly HttpClient client;

        public VersionsDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<string>> GetVersionsAsync()
        {
            return await BaseApplication.RequestAsync<IEnumerable<string>>(client, LolApiAddresses.DataDragonBaseAddress.CombineUri("api", "versions.json")).ConfigureAwait(false);
        }
    }
}
