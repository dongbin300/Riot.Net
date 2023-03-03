using Lol.Net.Objects;

using Riot.Net.Extensions;

using static Lol.Net.Objects.Models.LolModels.GameConstants;

namespace Lol.Net.Clients.LolApis
{
    public class LolGameConstantsApi : BaseClient
    {
        public LolGameConstantsApi(HttpClient client) : base(client)
        {

        }

        public async Task<IEnumerable<Season>?> GetSeasonsAsync()
        {
            return await GetAsync<IEnumerable<Season>>(client, LolApiAddresses.StaticAddress.CombineUri("seasons.json")).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Queue>?> GetQueuesAsync()
        {
            return await GetAsync<IEnumerable<Queue>>(client, LolApiAddresses.StaticAddress.CombineUri("queues.json")).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Map>?> GetMapsAsync()
        {
            return await GetAsync<IEnumerable<Map>>(client, LolApiAddresses.StaticAddress.CombineUri("maps.json")).ConfigureAwait(false);
        }

        public async Task<IEnumerable<GameMode>?> GetGameModesAsync()
        {
            return await GetAsync<IEnumerable<GameMode>>(client, LolApiAddresses.StaticAddress.CombineUri("gameModes.json")).ConfigureAwait(false);
        }

        public async Task<IEnumerable<GameType>?> GetGameTypesAsync()
        {
            return await GetAsync<IEnumerable<GameType>>(client, LolApiAddresses.StaticAddress.CombineUri("gameTypes.json")).ConfigureAwait(false);
        }

        public async Task DownloadRankedEmblemsFile(string localPath)
        {
            await DownloadFileAsync(client, LolApiAddresses.StaticAddress.CombineUri("ranked-emblems.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadRankedPositionsFile(string localPath)
        {
            await DownloadFileAsync(client, LolApiAddresses.StaticAddress.CombineUri("ranked-positions.zip"), localPath).ConfigureAwait(false);
        }

        public async Task DownloadTierIconsFile(string localPath)
        {
            await DownloadFileAsync(client, LolApiAddresses.StaticAddress.CombineUri("tier-icons.zip"), localPath).ConfigureAwait(false);
        }
    }
}
