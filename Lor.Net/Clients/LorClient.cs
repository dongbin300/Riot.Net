using Riot.Net.Clients;
using Riot.Net.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lor.Net.Clients
{
    public class LorClient : BaseClient
    {
        public DataDragon DataDragon { get; set; }
        public LolGameConstantsApi GameConstants { get; set; }
        public LiveClientDataApi LiveClientData { get; set; }
        public ReplayApi Replay { get; set; }

        public LorClient()
        {
            client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new DataDragon(client);
            GameConstants = new LolGameConstantsApi(client);
            LiveClientData = new LiveClientDataApi(client);
            Replay = new ReplayApi(client);
        }

        ~LorClient()
        {
            client.Dispose();
        }
    }
}
