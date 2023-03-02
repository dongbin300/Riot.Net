using Lol.Net.Objects.Models.GameClients.LiveClients;

namespace Lol.Net.Objects.Models.GameClients
{
    public record LiveGameData(ActivePlayer activePlayer, IEnumerable<LivePlayer> allPlayers, LiveGameData_Events events, LiveGameData_Data GameData);
    
    public record LiveGameData_Event(int EventID, string EventName, decimal EventTime);

    public record LiveGameData_Events(IEnumerable<LiveGameData_Event> Events);

    public record LiveGameData_Data(string gameMode, decimal gameTime, string mapName, int mapNumber, string mapTerrain);    
}