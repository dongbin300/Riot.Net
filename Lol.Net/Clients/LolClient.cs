using Lol.Net.Clients.DataDragons;
using Lol.Net.Clients.GameClientApis;
using Lol.Net.Clients.LolApis;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients
{
    public class LolClient : BaseClient
    {
        public LolDataDragon DataDragon { get; set; }
        public LolGameConstantsApi GameConstants { get; set; }
        public LiveClientDataApi LiveClientData { get; set; }
        public ReplayApi Replay { get; set; }

        public LolSummonerApi Summoner { get; set; }
        public LolStatusApi Status { get; set; }
        public LolChampionApi Champion { get; set; }
        public LolChampionMasteryApi ChampionMastery { get; set; }
        public LolSpectatorApi Spectator { get; set; }
        public LolLeagueApi League { get; set; }
        public LolTournamentStubApi TournamentStub { get; set; }
        public LolLeagueExpApi LeagueExp { get; set; }
        public LolClashApi Clash { get; set; }
        public LolMatchApi Match { get; set; }
        public LolChallengesApi Challenges { get; set; }

        public LolClient(string apiKey = "", PlatformRouting defaultPlatformRouting = PlatformRouting.None)
        {
            Client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new LolDataDragon(Client);
            GameConstants = new LolGameConstantsApi(Client);
            LiveClientData = new LiveClientDataApi(Client);
            Replay = new ReplayApi(Client);

            Summoner = new LolSummonerApi(Client, apiKey, defaultPlatformRouting);
            Status = new LolStatusApi(Client, apiKey, defaultPlatformRouting);
            Champion = new LolChampionApi(Client, apiKey, defaultPlatformRouting);
            ChampionMastery = new LolChampionMasteryApi(Client, apiKey, defaultPlatformRouting);
            Spectator = new LolSpectatorApi(Client, apiKey, defaultPlatformRouting);
            League = new LolLeagueApi(Client, apiKey, defaultPlatformRouting);
            TournamentStub = new LolTournamentStubApi(Client, apiKey, defaultPlatformRouting);
            LeagueExp = new LolLeagueExpApi(Client, apiKey, defaultPlatformRouting);
            Clash = new LolClashApi(Client, apiKey, defaultPlatformRouting);
            Match = new LolMatchApi(Client, apiKey, defaultPlatformRouting);
            Challenges = new LolChallengesApi(Client, apiKey, defaultPlatformRouting);
        }
    }
}
