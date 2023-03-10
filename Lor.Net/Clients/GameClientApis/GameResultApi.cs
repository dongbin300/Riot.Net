using Lor.Net.Objects;
using Lor.Net.Objects.Models;

using Riot.Net.Clients;
using Riot.Net.Extensions;

namespace Lor.Net.Clients.GameClientApis
{
    public class GameResultApi : BaseClient
    {
        public GameResultApi(HttpClient client) : base(client)
        {
        }

        public async Task<GameResult> GetGameResultAsync()
        {
            return await GetAsync<GameResult>(Client, LorApiAddresses.GameClientBaseAddress.CombineUri("game-result")).ConfigureAwait(false);
        }
    }
}
