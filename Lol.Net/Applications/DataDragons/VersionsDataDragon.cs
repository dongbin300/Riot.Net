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
            return await BaseApplication.RequestAsync<IEnumerable<string>>(client, "https://ddragon.leagueoflegends.com/api/versions.json").ConfigureAwait(false);
        }
    }
}
