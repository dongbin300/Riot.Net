using Lor.Net.Objects;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lor.Net.Clients.DataDragons
{
    public class CoreBundlesDataDragon : BaseClient
    {
        public CoreBundlesDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task DownloadLatestZipFile(string localPath)
        {
            await DownloadFileAsync(client, LorApiAddresses.BaseAddress.CombineUri("latest", "core-en_us.zip"), localPath).ConfigureAwait(false);
        }

        /// <summary>
        /// Download Versioned Zip File
        /// </summary>
        /// <param name="version">1_0_0</param>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public async Task DownloadVersionedZipFile(string version, string localPath)
        {
            await DownloadFileAsync(client, LorApiAddresses.BaseAddress.CombineUri(version, "core-en_us.zip"), localPath).ConfigureAwait(false);
        }
    }
}
