using Lor.Net.Objects;
using Lor.Net.Objects.Models;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lor.Net.Clients.GameClientApis
{
    public class CardPositionsApi : BaseClient
    {
        public CardPositionsApi(HttpClient client) : base(client)
        {
        }

        public async Task<CardPosition> GetPositionalRectanglesAsync()
        {
            return await GetAsync<CardPosition>(Client, LorApiAddresses.GameClientBaseAddress.CombineUri("positional-rectangles")).ConfigureAwait(false);
        }
    }
}
