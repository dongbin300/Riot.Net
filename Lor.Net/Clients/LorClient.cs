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
            Client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            DataDragon = new LorDataDragon(Client);
            ActiveDeck = new ActiveDeckApi(Client);
            CardPosition = new CardPositionsApi(Client);
            GameResult = new GameResultApi(Client);
        }

        ~LorClient()
        {
            Client.Dispose();
        }
    }
}
