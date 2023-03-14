using Riot.Net.Enums;

namespace Riot.Net.Clients
{
    public class ApiClient : BaseClient
    {
        protected string apiKey { get; set; }
        protected PlatformRouting defaultPlatformRouting { get; set; }
        protected RegionalRouting defaultRegionalRouting { get; set; }

        public ApiClient()
        {
            apiKey = string.Empty;
        }

        public ApiClient(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting)
        {
            Client = client;
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public ApiClient(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting, RegionalRouting defaultRegionalRouting)
        {
            Client = client;
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
            this.defaultRegionalRouting = defaultRegionalRouting;
        }
    }
}
