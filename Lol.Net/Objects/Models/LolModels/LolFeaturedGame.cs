namespace Lol.Net.Objects.Models.LolModels
{
    public record LolFeaturedGames(IEnumerable<LolFeaturedGame> gameList, long clientRefreshInterval);

    public record LolFeaturedGame(string gameMode, long gameLength, long mapId, string gameType, IEnumerable<LolFeaturedGameBannedChampion> bannedChampions, long gameId, LolFeaturedGameObserver observers, long gameQueueConfigId, long gameStartTime, IEnumerable<LolFeaturedGameParticipant> participants, string platformId);

    public record LolFeaturedGameBannedChampion(int pickTurn, long championId, long teamId);

    public record LolFeaturedGameObserver(string encryptionKey);

    public record LolFeaturedGameParticipant(bool bot, long spell2Id, long profileIconId, string summonerName, long championId, long teamId, long spell1Id);
}
