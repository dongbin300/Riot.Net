namespace Lol.Net.Objects.Models.DataDragons
{
    public record DataDragonRegions(DataDragonRegions_N n, string v, string l, string cdn, string dd, string lg, string css, int profileiconmax, object store);
    public record DataDragonRegions_N(string item, string rune, string mastery, string summoner, string champion, string profileicon, string map, string language, string sticker);
}
