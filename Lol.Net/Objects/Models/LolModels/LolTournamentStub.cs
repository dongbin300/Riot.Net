namespace Lol.Net.Objects.Models.LolModels
{
    public record LolTournamentStubLobbyEvents(IEnumerable<LolTournamentStubLobbyEvent> eventList);

    public record LolTournamentStubLobbyEvent(string summonerId, string eventType, string timestamp);
}
