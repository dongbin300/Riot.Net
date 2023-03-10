using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolTournamentStubApi : ApiClient
    {
        public LolTournamentStubApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<string>> CreateMockTournamentCodeAsync(long tournamentId, string tournamentCodeParametersJsonString, int count = 1)
        {
            return await PostAsync<IEnumerable<string>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/tournament-stub/v4/codes?count={count}&tournamentId={tournamentId}&api_key={apiKey}", tournamentCodeParametersJsonString).ConfigureAwait(false);
        }

        public async Task<LolTournamentStubLobbyEvents> GetMockListOfLobbyEventsByTournamentCodeAsync(string tournamentCode)
        {
            return await GetAsync<LolTournamentStubLobbyEvents>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/tournament-stub/v4/lobby-events/by-code/{tournamentCode}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<int> CreateMockTournamentProviderAsync(string providerRegistrationParametersJsonString)
        {
            return await PostAsync<int>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/tournament-stub/v4/providers?api_key={apiKey}", providerRegistrationParametersJsonString).ConfigureAwait(false);
        }

        public async Task<int> CreateMockTournamentAsync(string tournamentRegistrationParametersJsonString)
        {
            return await PostAsync<int>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/tournament-stub/v4/tournaments?api_key={apiKey}", tournamentRegistrationParametersJsonString).ConfigureAwait(false);
        }
    }
}