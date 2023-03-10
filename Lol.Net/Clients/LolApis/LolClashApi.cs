using Lol.Net.Objects.Models.LolModels;

using Riot.Net.Clients;
using Riot.Net.Enums;

namespace Lol.Net.Clients.LolApis
{
    public class LolClashApi : ApiClient
    {
        public LolClashApi(HttpClient client, string apiKey, PlatformRouting defaultPlatformRouting) : base(client, apiKey, defaultPlatformRouting)
        {
            this.apiKey = apiKey;
            this.defaultPlatformRouting = defaultPlatformRouting;
        }

        public async Task<IEnumerable<LolPlayer>> GetPlayersAsync(string summonerId)
        {
            return await GetAsync<IEnumerable<LolPlayer>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/clash/v1/players/by-summoner/{summonerId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolTeam> GetTeamAsync(string teamId)
        {
            return await GetAsync<LolTeam>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/clash/v1/teams/{teamId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<IEnumerable<LolTournament>> GetAllTournamentsAsync()
        {
            return await GetAsync<IEnumerable<LolTournament>>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/clash/v1/tournaments?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolTournament> GetTournamentByTeamIdAsync(string teamId)
        {
            return await GetAsync<LolTournament>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/clash/v1/tournaments/by-team/{teamId}?api_key={apiKey}").ConfigureAwait(false);
        }

        public async Task<LolTournament> GetTournamentByTournamentIdAsync(string tournamentId)
        {
            return await GetAsync<LolTournament>(Client, $"https://{defaultPlatformRouting}.api.riotgames.com/lol/clash/v1/tournaments/{tournamentId}?api_key={apiKey}").ConfigureAwait(false);
        }
    }
}