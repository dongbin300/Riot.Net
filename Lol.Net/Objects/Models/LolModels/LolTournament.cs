namespace Lol.Net.Objects.Models.LolModels
{
    public record LolTournament(int id, int themeId, string nameKey, string nameKeySecondary, IEnumerable<LolTournamentPhase> schedule);

    public record LolTournamentPhase(int id, long registrationTime, long startTime, bool cancelled);
}
