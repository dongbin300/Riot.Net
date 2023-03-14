using Riot.Net.Clients;

using Val.Net.Clients.ValApis;
using Val.Net.Enums;

namespace Val.Net.Clients
{
    public class ValClient : BaseClient
    {
        public ValContentApi Content { get; set; }
        public ValMatchApi Match { get; set; }
        public ValRankedApi Ranked { get; set; }
        public ValStatusApi Status { get; set; }

        public ValClient(string apiKey = "", ValRegion defaultValRegion = ValRegion.None)
        {
            Client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            Content = new ValContentApi(Client, apiKey, defaultValRegion);
            Match = new ValMatchApi(Client, apiKey, defaultValRegion);
            Ranked = new ValRankedApi(Client, apiKey, defaultValRegion);
            Status = new ValStatusApi(Client, apiKey, defaultValRegion);
        }
    }
}
