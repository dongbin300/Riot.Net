using Lor.Net.Enums;
using Lor.Net.Objects;

using Riot.Net.Clients;
using Riot.Net.Enums;
using Riot.Net.Extensions;

namespace Lor.Net.Clients.DataDragons
{
    public class SetBundlesDataDragon : BaseClient
    {
        public SetBundlesDataDragon(HttpClient client) : base(client)
        {
        }

        public async Task DownloadLatestZipFile(SetBundleTypeEnum setBundleType, LanguageEnum language, string localPath)
        {
            var fileName = setBundleType.Id + "-" + language.Id + ".zip";
            
            await DownloadFileAsync(Client, LorApiAddresses.BaseAddress.CombineUri("latest", fileName), localPath).ConfigureAwait(false);
        }

        /// <summary>
        /// Download Versioned Zip File
        /// </summary>
        /// <param name="version">1_0_0</param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public async Task DownloadVersionedZipFile(string version, SetBundleTypeEnum setBundleType, LanguageEnum language, string localPath)
        {
            var fileName = setBundleType.Id + "-" + language.Id + ".zip";

            await DownloadFileAsync(Client, LorApiAddresses.BaseAddress.CombineUri(version, fileName), localPath).ConfigureAwait(false);
        }

        public async Task<byte[]> GetCardImagesAsync(SetBundleTypeEnum setBundleType, LanguageEnum language, string cardId, bool isAlt = false, bool isFull = false)
        {
            var options = (isAlt ? "-alt" : "") + (isFull ? "-full" : "");
            return await GetBytesAsync(Client, LorApiAddresses.BaseAddress.CombineUri("latest", setBundleType.Id, language.Id, "img", "cards", cardId + options + ".png")).ConfigureAwait(false);
        }
    }
}
