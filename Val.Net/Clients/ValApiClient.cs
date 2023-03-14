using Riot.Net.Clients;

using Val.Net.Enums;

namespace Val.Net.Clients
{
    public class ValApiClient : ApiClient
    {
        protected ValRegion defaultValRegion { get; set; }

        public ValApiClient(HttpClient client, string apiKey, ValRegion defaultValRegion)
        {
            Client = client;
            this.apiKey = apiKey;
            this.defaultValRegion = defaultValRegion;
        }
    }
}
