namespace Lol.Net.Applications.DataDragons
{
    public class DataDragon
    {
        private readonly string defaultVersion = "13.4.1";
        private readonly HttpClient client;
        public VersionsDataDragon Versions { get; }
        public RegionsDataDragon Regions { get; }
        public DataAndAssetsDataDragon DataAndAssets { get; }
        public ChampionsDataDragon Champions { get; }
        public ItemsDataDragon Items { get; }
        public OtherDataDragon Other { get; }

        public DataDragon(HttpClient client)
        {
            this.client = client;
            Versions = new VersionsDataDragon(client);
            Regions = new RegionsDataDragon(client);
            DataAndAssets = new DataAndAssetsDataDragon(client);
            Champions = new ChampionsDataDragon(client);
            Items = new ItemsDataDragon(client);
            Other = new OtherDataDragon(client);
        }

        public async Task DownloadLatestTgzFile(string localPath)
        {
            var versions = await Versions.GetVersionsAsync().ConfigureAwait(false);
            var latestVersion = versions?[0] ?? defaultVersion;
            await BaseApplication.DownloadFileAsync(client, $"https://ddragon.leagueoflegends.com/cdn/dragontail-{latestVersion}.tgz", localPath).ConfigureAwait(false);
        }

        public async Task DownloadTgzFile(string localPath)
        {
            await BaseApplication.DownloadFileAsync(client, "https://ddragon.leagueoflegends.com/cdn/dragontail-13.4.1.tgz", localPath).ConfigureAwait(false);
        }

        public async Task DownloadZipFile(string localPath)
        {
            await BaseApplication.DownloadFileAsync(client, "https://ddragon.leagueoflegends.com/cdn/dragontail-10.10.5.zip", localPath).ConfigureAwait(false);
        }
        
    }
}
