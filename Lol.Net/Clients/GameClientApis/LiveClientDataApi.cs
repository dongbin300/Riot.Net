using Lol.Net.Objects;
using Lol.Net.Objects.Models.GameClients;
using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lol.Net.Clients.GameClientApis
{
    public class LiveClientDataApi : BaseClient
    {
        public LiveClientDataApi(HttpClient client) : base(client)
        {

        }

        public async Task<LiveGameData> GetAllGameData()
        {
            return await GetAsync<LiveGameData>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("allgamedata")).ConfigureAwait(false);
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
            return await GetAsync<LolAbilities>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("activeplayerabilities")).ConfigureAwait(false);
        }

        public async Task<LolFullRune> GetActivePlayerRunes()
        {
            return await GetAsync<LolFullRune>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("activeplayerrunes")).ConfigureAwait(false);
        }

        public async Task GetActivePlayerList()
        {
            //return await BaseApplication.RequestAsync<LiveGameData>(client, "https://127.0.0.1:2999/liveclientdata/playerlist").ConfigureAwait(false);
        }

        public async Task<LolScore> GetActivePlayerScores(string summonerName)
        {
            return await GetAsync<LolScore>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playerscores?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LolShortSummonerSpells> GetActivePlayerSummonerSpells(string summonerName)
        {
            return await GetAsync<LolShortSummonerSpells>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playersummonerspells?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LolRune> GetActivePlayerMainRunes(string summonerName)
        {
            return await GetAsync<LolRune>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playermainrunes?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolLiveItem>> GetActivePlayerItems(string summonerName)
        {
            return await GetAsync<IEnumerable<LolLiveItem>>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("playeritems?summonerName=", summonerName)).ConfigureAwait(false);
        }

        public async Task<LiveGameData_Events> GetEventData()
        {
            return await GetAsync<LiveGameData_Events>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("eventdata")).ConfigureAwait(false);
        }

        public async Task<LiveGameData_Data> GetGameStats()
        {
            return await GetAsync<LiveGameData_Data>(client, LolApiAddresses.LiveClientDataAddress.CombineUri("gamestats")).ConfigureAwait(false);
        }
    }
}
