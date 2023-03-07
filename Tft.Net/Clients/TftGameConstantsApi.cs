using Riot.Net.Clients;
using Riot.Net.Extensions;

using Tft.Net.Objects;

namespace Tft.Net.Clients
{
    /// <summary>
    /// There is no static content automatically built for each patch of Teamfight Tactics. Many of the assets from Teamfight Tactics can be gathered from League of Legends' Data Dragon.
    /// <see cref="https://developer.riotgames.com/docs/tft#static-data"/>
    /// </summary>
    public class TftGameConstantsApi : BaseClient
    {
        public async Task DownloadSet5File(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set5patch1112.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadSet4UpdateFile(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set4update.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadSet4File(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set4.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadSet3UpdateFile(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set3update.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadSet3File(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set3.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadSet2File(string localPath)
        {
            await DownloadFileAsync(client, TftApiAddresses.BaseAddress.CombineUri("set2.zip"), localPath).ConfigureAwait(false);
        }
    }
}
