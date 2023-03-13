using Riot.Net.Clients;
using Riot.Net.Enums;

using Tft.Net.Clients.TftApis;

namespace Tft.Net.Clients
{
    public class TftClient : BaseClient
    {
        public TftLeagueApi League { get; set; }
        public TftSummonerApi Summoner { get; set; }

        public TftClient(string apiKey = "", PlatformRouting defaultPlatformRouting = PlatformRouting.None, RegionalRouting defaultRegionalRouting = RegionalRouting.None)
        {
            Client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });

            League = new TftLeagueApi(Client, apiKey, defaultPlatformRouting);
            Summoner = new TftSummonerApi(Client, apiKey, defaultPlatformRouting);
        }
    }
}
