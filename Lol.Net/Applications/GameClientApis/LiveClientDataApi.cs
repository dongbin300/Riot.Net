using Lol.Net.Objects;
using Lol.Net.Objects.Models.GameClients;
using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Extensions;

namespace Lol.Net.Applications.GameClientApis
{
    public class LiveClientDataApi
    {
        private readonly HttpClient client;

        public LiveClientDataApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<LiveGameData> GetAllGameData()
        {
            return await BaseApplication.RequestAsync<LiveGameData>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("allgamedata")).ConfigureAwait(false);
        }

        public async Task GetActivePlayer()
        {
            //return await BaseApplication.RequestAsync<LiveGameData>(client, "https://127.0.0.1:2999/liveclientdata/allgamedata").ConfigureAwait(false);
        }

        public async Task GetActivePlayerName()
        {
            //return await BaseApplication.RequestAsync<LiveGameData>(client, "https://127.0.0.1:2999/liveclientdata/allgamedata").ConfigureAwait(false);
        }

        public async Task<LolAbilities> GetActivePlayerAbilities()
        {
            return await BaseApplication.RequestAsync<LolAbilities>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("activeplayerabilities")).ConfigureAwait(false);
        }

        public async Task<LolFullRune> GetActivePlayerRunes()
        {
            return await BaseApplication.RequestAsync<LolFullRune>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("activeplayerrunes")).ConfigureAwait(false);
        }

        public async Task GetActivePlayerList()
        {
            //return await BaseApplication.RequestAsync<LiveGameData>(client, "https://127.0.0.1:2999/liveclientdata/playerlist").ConfigureAwait(false);
        }

        public async Task<LolScore> GetActivePlayerScores(string summonerName)
        {
            return await BaseApplication.RequestAsync<LolScore>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playerscores?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LolShortSummonerSpells> GetActivePlayerSummonerSpells(string summonerName)
        {
            return await BaseApplication.RequestAsync<LolShortSummonerSpells>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playersummonerspells?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LolRune> GetActivePlayerMainRunes(string summonerName)
        {
            return await BaseApplication.RequestAsync<LolRune>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playermainrunes?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolLiveItem>> GetActivePlayerItems(string summonerName)
        {
            return await BaseApplication.RequestAsync<IEnumerable<LolLiveItem>>(client, LolApiAddresses.LiveClientDataAddress.CombineUri(relativeUris: "playeritems?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LiveGameData_Events> GetEventData()
        {
            return await BaseApplication.RequestAsync<LiveGameData_Events>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("eventdata")).ConfigureAwait(false);
        }

        public async Task<LiveGameData_Data> GetGameStats()
        {
            return await BaseApplication.RequestAsync<LiveGameData_Data>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("gamestats")).ConfigureAwait(false);
        }
    }
}
