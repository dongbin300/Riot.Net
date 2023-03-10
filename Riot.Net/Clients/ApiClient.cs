using Riot.Net.Enums;

namespace Riot.Net.Clients
{
    public class ApiClient : BaseClient
    {
        protected string apiKey { get; set; }
        protected PlatformRouting defaultPlatformRouting { get; set; }

        public ApiClient(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting)
        {
            Client = client;
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }
    }
}
