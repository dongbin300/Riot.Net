namespace Lol.Net.Objects.Models.LolModels
{
    public record LolCurrentGame(long gameId, string gameType, long gameStartTime, long mapId, long gameLength, string platformId, string gameMode, IEnumerable<LolCurrentGameBannedChampion> bannedChampions, long gameQueueConfigId, LolCurrentGameObserver observers, IEnumerable<LolCurrentGameParticipant> participants);

    public record LolCurrentGameBannedChampion(int pickTurn, long championId, long teamId);

    public record LolCurrentGameObserver(string encryptionKey);

    public record LolCurrentGameParticipant(long championId, LolCurrentGamePerks perks, long profileIconId, bool bot, long teamId, string summonerName, string summonerId, long spell1Id, long spell2Id, IEnumerable<LolCurrentGameCustomizationObject> gameCustomizationObjects);

    public record LolCurrentGamePerks(IEnumerable<long> perkIds, long perkStyle, long perkSubStyle);

    public record LolCurrentGameCustomizationObject(string category, string content);
}
