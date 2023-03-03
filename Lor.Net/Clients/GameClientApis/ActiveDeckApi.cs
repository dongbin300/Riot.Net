using Lor.Net.Objects;
using Lor.Net.Objects.Models;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lor.Net.Clients.GameClientApis
{
    public class ActiveDeckApi : BaseClient
    {
        public ActiveDeckApi(HttpClient client) : base(client)
        {
        }

        public async Task<ActiveDeck> GetStaticDecklistAsync()
        {
            return await GetAsync<ActiveDeck>(client, LorApiAddresses.GameClientBaseAddress.CombineUri("static-decklist")).ConfigureAwait(false);
        }
    }
}
