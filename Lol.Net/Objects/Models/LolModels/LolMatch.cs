namespace Lol.Net.Objects.Models.LolModels
{
    public record LolMatch(LolMatchMetadata metadata, LolMatchInfo info);

    public record LolMatchTimeline(LolMatchMetadata metadata, LolMatchTimelineInfo info);

    public record LolMatchMetadata(string dataVersion, string matchId, IEnumerable<string> participants);

    public record LolMatchInfo(long gameCreation, long gameDuration, long gameEndTimestamp, long gameId, string gameMode, string gameName, long gameStartTimestamp, string gameType, string gameVersion, int mapId, IEnumerable<LolMatchParticipant> participants, string platformId, int queueId, IEnumerable<LolMatchTeam> teams, string tournamentCode);

    public record LolMatchTimelineInfo(int frameInterval, IEnumerable<LolMatchTimelineInfoFrame> frames, long gameId, IEnumerable<LolMatchTimelineInfoParticipant> participants);

    public record LolMatchTimelineInfoFrame(IEnumerable<LolMatchTimelineInfoFrameEvent> events, LolMatchTimelineInfoFrameParticipantFrames participantFrames, int timestamp);

    public record LolMatchTimelineInfoFrameEvent(long realTimestamp, int timestamp, string type, int itemId, int participantId, string levelUpType, int skillSlot, int creatorId, string wardType, int level, IEnumerable<int> assistingParticipantIds, int bounty, int killStreakLength, int killerId, LolMatchTimelinePosition position, IEnumerable<LolMatchTimelineInfoFrameEventVictimDamageReceived> victimDamageDealt, IEnumerable<LolMatchTimelineInfoFrameEventVictimDamageReceived> victimDamageReceived, int victimId, string killType, string laneType, int teamId, int multiKillLength, int killerTeamId, string monsterType, string monsterSubType, string buildingType, string towerType, int afterId, int beforeId, int goldGain, long gameId, int winningTeam, string transformType, string name, int shutdownBounty, long actualStartTime);

    public record LolMatchTimelinePosition(int x, int y);

    public record LolMatchTimelineInfoFrameEventVictimDamageReceived(bool basic, int magicDamage, string name, int participantId, int physicalDamage, string spellName, int spellSlot, int trueDamage, string type);

    public record LolMatchTimelineInfoFrameParticipantFrames(LolMatchTimelineInfoFrameParticipantFrame _1, LolMatchTimelineInfoFrameParticipantFrame _2, LolMatchTimelineInfoFrameParticipantFrame _3, LolMatchTimelineInfoFrameParticipantFrame _4, LolMatchTimelineInfoFrameParticipantFrame _5, LolMatchTimelineInfoFrameParticipantFrame _6, LolMatchTimelineInfoFrameParticipantFrame _7, LolMatchTimelineInfoFrameParticipantFrame _8, LolMatchTimelineInfoFrameParticipantFrame _9, LolMatchTimelineInfoFrameParticipantFrame _10);

    public record LolMatchTimelineInfoFrameParticipantFrame(LolMatchTimelineInfoFrameParticipantFrameChampionStats championStats, int currentGold, LolMatchTimelineInfoFrameParticipantFrameDamageStats damageStats, int goldPerSecond, int jungleMinionsKilled, int level, int minionsKilled, int participantId, LolMatchTimelinePosition position, int timeEnemySpentControlled, int totalGold, int xp);

    public record LolMatchTimelineInfoFrameParticipantFrameChampionStats(int abilityHaste, int abilityPower, int armor, int armorPen, int armorPenPercent, int attackDamage, int attackSpeed, int bonusArmorPenPercent, int bonusMagicPenPercent, int ccReduction, int cooldownReduction, int health, int healthMax, int healthRegen, int lifesteal, int magicPen, int magicPenPercent, int magicRegist, int movementSpeed, int omnivamp, int physicalVamp, int power, int powerMax, int powerRegen, int spellVamp);

    public record LolMatchTimelineInfoFrameParticipantFrameDamageStats(int magicDamageDone, int magicDamageDoneToChampions, int magicDamageTaken, int physicalDamageDone, int physicalDamageDoneToChampions, int physicalDamageTaken, int totalDamageDone, int totalDamageDoneToChampions, int totalDamageTaken, int trueDamageDone, int trueDamageDoneToChampions, int trueDamageTaken);

    public record LolMatchTimelineInfoParticipant(int participantId, string puuid);

    public record LolMatchParticipant(int assists, int baronKills, int bountyLevel, int champExperience, int champLevel, int championId, string championName, int championTransform, int consumablesPurchased, int damageDealtToBuildings, int damageDealtToObjectives, int damageDealtToTurrets, int damageSelfMitigated, int deaths, int detectorWardsPlaced, int doubleKills, int dragonKills, bool firstBloodAssist, bool firstBloodKill, bool firstTowerAssist, bool firstTowerKill, bool gameEndedInEarlySurrender, bool gameEndedInSurrender, int goldEarned, int goldSpent, string individualPosition, int inhibitorKills, int inhibitorTakedowns, int inhibitorsLost, int item0, int item1, int item2, int item3, int item4, int item5, int item6, int itemsPurchased, int killingSprees, int kills, string lane, int largestCriticalStrike, int largestKillingSpree, int largestMultiKill, int longestTimeSpentLiving, int magicDamageDealt, int magicDamageDealtToChampions, int magicDamageTaken, int neutralMinionsKilled, int nexusKills, int nexusTakedowns, int nexusLost, int objectivesStolen, int objectivesStolenAssists, int participantId, int pentaKills, LolMatchPerks perks, int physicalDamageDealt, int physicalDamageDealtToChampions, int physicalDamageTaken, int profileIcon, string puuid, int quadraKills, string riotIdName, string riotIdTagline, string role, int sightWardsBoughtInGame, int spell1Casts, int spell2Casts, int spell3Casts, int spell4Casts, int summoner1Casts, int summoner1Id, int summoner2Casts, int summoner2Id, string summonerId, int summonerLevel, string summonerName, bool teamEarlySurrendered, int teamId, string teamPosition, int timeCCingOthers, int timePlayed, int totalDamageDealt, int totalDamageDealtToChampions, int totalDamageShieldedOnTeammates, int totalDamageTaken, int totalHeal, int totalHealsOnTeammates, int totalMinionsKilled, int totalTimeCCDealt, int totalTimeSpentDead, int totalUnitsHealed, int tripleKills, int trueDamageDealt, int trueDamageDealtToChampions, int trueDamageTaken, int turretKills, int turretTakedowns, int turretsLost, int unrealKills, int visionScore, int visionWardsBoughtInGame, int wardsKilled, int wardsPlaced, bool win);

    public record LolMatchPerks(LolMatchPerkStats statPerks, IEnumerable<LolMatchPerkStyle> styles);

    public record LolMatchPerkStats(int defense, int flex, int offense);

    public record LolMatchPerkStyle(string description, IEnumerable<LolMatchPerkStyleSelection> selections, int style);

    public record LolMatchPerkStyleSelection(int perk, int var1, int var2, int var3);

    public record LolMatchTeam(IEnumerable<LolMatchBan> bans, LolMatchObjectives objectives, int teamId, bool win);

    public record LolMatchBan(int championId, int pickTurn);

    public record LolMatchObjectives(LolMatchObjective baron, LolMatchObjective champion, LolMatchObjective dragon, LolMatchObjective inhibitor, LolMatchObjective riftHerald, LolMatchObjective tower);

    public record LolMatchObjective(bool first, int kills);
}
