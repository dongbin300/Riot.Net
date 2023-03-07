using Lor.Net.Clients.DataDragons;
using Lor.Net.Clients.GameClientApis;

using Riot.Net.Clients;

namespace Lor.Net.Clients
{
    public class LorClient : BaseClient
    {
        public LorDataDragon DataDragon { get; set; }
        public ActiveDeckApi ActiveDeck { get; set; }
        public CardPositionsApi CardPosition { get; set; }
        public GameResultApi GameResult { get; set; }

        public LorClient()
        {
            client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new LorDataDragon(client);
            ActiveDeck = new ActiveDeckApi(client);
            CardPosition = new CardPositionsApi(client);
            GameResult = new GameResultApi(client);
        }

        ~LorClient()
        {
            client.Dispose();
        }
    }
}
