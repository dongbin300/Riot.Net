namespace Lol.Net.Objects.Models.LolModels
{
    public record LolTeam(string id, int tournamentId, string name, int iconId, int tier, string captain, string abbreviation, IEnumerable<LolPlayer> players);
}
