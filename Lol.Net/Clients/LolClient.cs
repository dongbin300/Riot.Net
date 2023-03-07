using Lol.Net.Clients.DataDragons;
using Lol.Net.Clients.GameClientApis;

using Riot.Net.Clients;

namespace Lol.Net.Clients
{
    public class LolClient : BaseClient
    {
        public LolDataDragon DataDragon { get; set; }
        public LolGameConstantsApi GameConstants { get; set; }
        public LiveClientDataApi LiveClientData { get; set; }
        public ReplayApi Replay { get; set; }

        public LolClient()
        {
            client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new LolDataDragon(client);
            GameConstants = new LolGameConstantsApi(client);
            LiveClientData = new LiveClientDataApi(client);
            Replay = new ReplayApi(client);
        }

        ~LolClient()
        {
            client.Dispose();
        }
    }
}
