using Lol.Net.Clients.DataDragons;
using Lol.Net.Clients.GameClientApis;
using Lol.Net.Clients.LolApis;

namespace Lol.Net.Clients
{
    public class LolClient : BaseClient
    {
        public DataDragon DataDragon { get; set; }
        public LolGameConstantsApi GameConstants { get; set; }
        public LiveClientDataApi LiveClientData { get; set; }
        public ReplayApi Replay { get; set; }

        public LolClient()
        {
            client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new DataDragon(client);
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
