using Riot.Net.Clients;

using Val.Net.Clients.ValApis;
using Val.Net.Enums;

namespace Val.Net.Clients
{
    public class ValClient : BaseClient
    {
        public ValContentApi Content { get; set; }

        public ValClient(string apiKey = "", ValRegion defaultValRegion = ValRegion.None)
        {
            Client = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true });
            Content = new ValContentApi(Client, apiKey, defaultValRegion);
        }
    }
}
