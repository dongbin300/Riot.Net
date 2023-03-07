using Lol.Net.Objects;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.DataDragons
{
    public class LolDataDragon : BaseClient
    {
        private readonly string defaultVersion = "13.4.1";
        public VersionsDataDragon Versions { get; }
        public RegionsDataDragon Regions { get; }
        public DataAndAssetsDataDragon DataAndAssets { get; }
        public ChampionsDataDragon Champions { get; }
        public ItemsDataDragon Items { get; }
        public OtherDataDragon Other { get; }

        public LolDataDragon(HttpClient client) : base(client)
        {
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
            var latestVersion = versions.First() ?? defaultVersion;
            await DownloadFileAsync(client, LolApiAddresses.DataDragonHttpsAddress.CombineUri("dragontail-", latestVersion + ".tgz"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadTgzFile(string localPath)
        {
            await DownloadFileAsync(client, LolApiAddresses.DataDragonHttpsAddress.CombineUri("dragontail-13.4.1.tgz"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadZipFile(string localPath)
        {
            await DownloadFileAsync(client, LolApiAddresses.DataDragonHttpsAddress.CombineUri("dragontail-10.10.5.zip"), localPath).ConfigureAwait(false);
        }
    }
}
