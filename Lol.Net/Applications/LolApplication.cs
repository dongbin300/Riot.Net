using Lol.Net.Applications.DataDragons;
using Lol.Net.Applications.GameClientApis;
using Lol.Net.Applications.LolApis;

namespace Lol.Net.Applications
{
    public class LolApplication : BaseApplication
    {
        private readonly HttpClient client;
        public DataDragon DataDragon { get; set; }
        public LolGameConstantsApi GameConstants { get; set; }
        public LiveClientDataApi LiveClientData { get; set; }
        public ReplayApi Replay { get; set; }

        public LolApplication()
        {
            client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new DataDragon(client);
            GameConstants = new LolGameConstantsApi(client);
            LiveClientData = new LiveClientDataApi(client);
            Replay = new ReplayApi(client);
        }

        ~LolApplication()
        {
            client.Dispose();
        }
    }
}
