using static Lol.Net.Objects.Models.LolModels.GameConstants;

namespace Lol.Net.Applications.LolApis
{
    public class LolGameConstantsApi
    {
        private readonly HttpClient client;

        public LolGameConstantsApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<IList<Season>?> GetSeasonsAsync()
        {
            return await BaseApplication.RequestAsync<IList<Season>>(client, "https://static.developer.riotgames.com/docs/lol/seasons.json").ConfigureAwait(false);
        }

        public async Task<IList<Queue>?> GetQueuesAsync()
        {
            return await BaseApplication.RequestAsync<IList<Queue>>(client, "https://static.developer.riotgames.com/docs/lol/queues.json").ConfigureAwait(false);
        }

        public async Task<IList<Map>?> GetMapsAsync()
        {
            return await BaseApplication.RequestAsync<IList<Map>>(client, "https://static.developer.riotgames.com/docs/lol/maps.json").ConfigureAwait(false);
        }

        public async Task<IList<GameMode>?> GetGameModesAsync()
        {
            return await BaseApplication.RequestAsync<IList<GameMode>>(client, "https://static.developer.riotgames.com/docs/lol/gameModes.json").ConfigureAwait(false);
        }

        public async Task<IList<GameType>?> GetGameTypesAsync()
        {
            return await BaseApplication.RequestAsync<IList<GameType>>(client, "https://static.developer.riotgames.com/docs/lol/gameTypes.json").ConfigureAwait(false);
        }

        public async Task DownloadRankedEmblemsFile(string localPath)
        {
            await BaseApplication.DownloadFileAsync(client, "https://static.developer.riotgames.com/docs/lol/ranked-emblems.zip", localPath).ConfigureAwait(false);
        }

        public async Task DownloadRankedPositionsFile(string localPath)
        {
            await BaseApplication.DownloadFileAsync(client, "https://static.developer.riotgames.com/docs/lol/ranked-positions.zip", localPath).ConfigureAwait(false);
        }

        public async Task DownloadTierIconsFile(string localPath)
        {
            await BaseApplication.DownloadFileAsync(client, "https://static.developer.riotgames.com/docs/lol/tier-icons.zip", localPath).ConfigureAwait(false);
        }
    }
}
