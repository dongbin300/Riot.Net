namespace Lol.Net.Objects.Models.LolModels
{
    public class GameConstants
    {
        public record Season(int id, string season);
        public record Queue(int queueId, string map, string description, string notes);
        public record Map(int mapId, string mapName, string notes);
        public record GameMode(string gameMode, string description);
        public record GameType(string gametype, string description);
    }
}
