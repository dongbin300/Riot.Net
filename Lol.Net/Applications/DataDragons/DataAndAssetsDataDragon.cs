namespace Lol.Net.Applications.DataDragons
{
    public class DataAndAssetsDataDragon
    {
        private readonly HttpClient client;

        public DataAndAssetsDataDragon(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IList<string>?> GetLanguagesAsync()
        {
            return await BaseApplication.RequestAsync<IList<string>>(client, "https://ddragon.leagueoflegends.com/cdn/languages.json").ConfigureAwait(false);
        }
    }
}
