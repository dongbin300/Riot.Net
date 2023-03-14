namespace Val.Net.Objects.Models.ValModels
{
    public record ValMatch(ValMatchInfo matchInfo, IEnumerable<ValMatchPlayer> players, IEnumerable<ValMatchCoach> coaches, IEnumerable<ValMatchTeam> teams, IEnumerable<ValMatchRoundResult> roundResults);

    public record ValMatchInfo(string matchId, string mapId, int gameLengthMillis, long gameStartMillis, string provisioningFlowId, bool isCompleted, string customGameName, string queueId, string gameMode, bool isRanked, string seasonId);

    public record ValMatchPlayer(string puuid, string gameName, string tagLine, string teamId, string partyId, string characterId, ValMatchPlayerStats stats, int competitiveTier, string playerCard, string playerTitle);

    public record ValMatchPlayerStats(int score, int roundsPlayed, int kills, int deaths, int assists, int playtimeMillis, ValMatchAbilityCasts abilityCasts);

    public record ValMatchAbilityCasts(int grenadeCasts, int ability1Casts, int ability2Casts, int ultimateCasts);

    public record ValMatchCoach(string puuid, string teamId);

    public record ValMatchTeam(string teamId, bool won, int roundsPlayed, int roundsWon, int numPoints);

    public record ValMatchRoundResult(int roundNum, string roundResult, string roundCeremony, string winningTeam, string bombPlanter, string bombDefuser, int plantRoundTime, IEnumerable<ValMatchPlayerLocations> plantPlayerLocations, ValMatchLocation plantLocation, string plantSite, int defuseRoundTime, IEnumerable<ValMatchPlayerLocations> defusePlayerLocations, ValMatchLocation defuseLocation, IEnumerable<ValMatchPlayerRoundStats> playerStats, string roundResultCode);

    public record ValMatchPlayerLocations(string puuid, decimal viewRadians, ValMatchLocation location);

    public record ValMatchLocation(int x, int y);

    public record ValMatchPlayerRoundStats(string puuid, IEnumerable<ValMatchKill> kills, IEnumerable<ValMatchDamage> damage, int score, ValMatchEconomy economy, ValMatchAbility ability);

    public record ValMatchKill(int timeSinceGameStartMillis, int timeSinceRoundStartMillis, string killer, string victim, ValMatchLocation victimeLocation, IEnumerable<string> assistants, IEnumerable<ValMatchPlayerLocations> playerLocations, ValMatchFinishingDamage finishingDamage);

    public record ValMatchFinishingDamage(string damageType, string damageItem, bool isSecondaryFireMode);

    public record ValMatchDamage(string receiver, int damage, int legshots, int bodyshots, int headshots);

    public record ValMatchEconomy(int loadoutValue, string weapon, string armor, int remaining, int spent);

    public record ValMatchAbility(string grenadeEffects, string ability1Effects, string ability2Effects, string ultimateEffects);

    public record ValMatchlist(string puuid, IEnumerable<ValMatchlistEntry> history);

    public record ValMatchlistEntry(string matchId, long gameStartTimeMillis, string teamId);

    public record ValRecentMatches(long currentTime, IEnumerable<string> matchIds);
}
