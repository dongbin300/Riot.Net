using Lol.Net.Objects.Models.DataDragons;

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
            return await BaseApplication.RequestAsync<DataDragonRegions>(client, "https://ddragon.leagueoflegends.com/realms/na.json").ConfigureAwait(false);
        }
    }
}
