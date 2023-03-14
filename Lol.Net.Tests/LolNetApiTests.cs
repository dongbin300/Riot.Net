using Lol.Net.Clients;

using Riot.Net;
using Riot.Net.Enums;

namespace Lol.Net.Tests
{
    public class LolNetApiTests
    {
        LolClient app;
        const string summonerId = "h5QkG9WoGSTV7AsrHtTRtrYLrxIIvSeSA5bU1I6Pri3b4g";
        const string accountId = "B8YQkkbqAgkm1jTwU98tbBEf7zk3OPpCIoSLfdRGTsPh";
        const string puuId = "FfTfELL3_FSozEhxiMhytHAGMHH6cQ8HvYxWLcoKBh43WCLS1cLfoLSW7pgw2GciTBO0ywbxWSazkQ";

        [SetUp]
        public void Setup()
        {
            app = new LolClient(Configuration.DevelopmentApiKey, PlatformRouting.KR, RegionalRouting.ASIA);
        }

        [Test]
        public async Task GetAllBasicChallengeConfigInfoAsync()
        {
            var result = await app.Challenges.GetAllBasicChallengeConfigInfoAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetAllLevelToPercentilesOfPlayersAsync()
        {
            var result = await app.Challenges.GetAllLevelToPercentilesOfPlayersAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.percentiles, Is.Not.Empty);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public async Task GetChallengeConfigAsync(long challengeId)
        {
            var result = await app.Challenges.GetChallengeConfigAsync(challengeId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.thresholds, Is.Not.Empty);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public async Task GetLevelToPercentilesAsync(long challengeId)
        {
            var result = await app.Challenges.GetLevelToPercentilesAsync(challengeId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(puuId)]
        public async Task GetPlayerInfoAsync(string puuId)
        {
            var result = await app.Challenges.GetPlayerInfoAsync(puuId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.challenges, Is.Not.Empty);
            Assert.That(result.categoryPoints, Is.Not.Empty);
        }

        [TestCase(0, "MASTER")]
        [TestCase(1, "GRANDMASTER")]
        [TestCase(2, "CHALLENGER")]
        public async Task GetTopPlayersByLevelAsync(long challengeId, string level)
        {
            var result = await app.Challenges.GetTopPlayersByLevelAsync(challengeId, level);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetChampionRotationsAsync()
        {
            var result = await app.Champion.GetChampionRotationsAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.freeChampionIds, Is.Not.Empty);
        }

        [TestCase(summonerId)]
        public async Task GetChampionRotationsAsync(string summonerId)
        {
            var result = await app.ChampionMastery.GetAllChampionMasteryAsync(summonerId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(summonerId, 67)]
        [TestCase(summonerId, 104)]
        [TestCase(summonerId, 4)]
        public async Task GetChampionMasteryByChampionIdAsync(string summonerId, long championId)
        {
            var result = await app.ChampionMastery.GetChampionMasteryByChampionIdAsync(summonerId, championId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(summonerId)]
        public async Task GetTopChampionMasteryAsync(string summonerId)
        {
            var result = await app.ChampionMastery.GetTopChampionMasteryAsync(summonerId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(summonerId)]
        public async Task GetTotalChampionMasteryScoreAsync(string summonerId)
        {
            var result = await app.ChampionMastery.GetTotalChampionMasteryScoreAsync(summonerId);
            Assert.That(result, Is.Not.NaN);
        }

        [TestCase(Queue.RankedSolo55, Tier.DIAMOND, Division.IV)]
        public async Task GetAllLeagueEntriesAsync(Queue queue, Tier tier, Division division)
        {
            var result = await app.League.GetAllLeagueEntriesAsync(queue, tier, division);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(summonerId)]
        public async Task GetAllQueuesBySummonerIdAsync(string summonerId)
        {
            var result = await app.League.GetAllQueuesBySummonerIdAsync(summonerId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(Queue.RankedSolo55)]
        public async Task GetChallengerLeagueByQueueAsync(Queue queue)
        {
            var result = await app.League.GetChallengerLeagueByQueueAsync(queue);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase(Queue.RankedSolo55)]
        public async Task GetGrandmasterLeagueByQueueAsync(Queue queue)
        {
            var result = await app.League.GetGrandmasterLeagueByQueueAsync(queue);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase("70d8c920-e79e-383e-b905-f8e94c2955d2")]
        public async Task GetLeagueByLeagueIdAsync(string leagueId)
        {
            var result = await app.League.GetLeagueByLeagueIdAsync(leagueId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase(Queue.RankedSolo55)]
        public async Task GetMasterLeagueByQueueAsync(Queue queue)
        {
            var result = await app.League.GetMasterLeagueByQueueAsync(queue);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase(Queue.RankedSolo55, Tier.MASTER, Division.I)]
        public async Task GetAllLeagueExpEntriesAsync(Queue queue, Tier tier, Division division)
        {
            var result = await app.LeagueExp.GetAllLeagueEntriesAsync(queue, tier, division);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("KR_6402179850")]
        [TestCase("KR_6402155817")]
        [TestCase("KR_6399807094")]
        public async Task GetMatchByMatchIdAsync(string matchId)
        {
            var result = await app.Match.GetMatchByMatchIdAsync(matchId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.info, Is.Not.Null);
        }

        [TestCase(puuId)]
        public async Task GetMatchIdsByPuuIdAsync(string puuId)
        {
            var result = await app.Match.GetMatchIdsByPuuIdAsync(puuId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("KR_6402179850")]
        [TestCase("KR_6402155817")]
        [TestCase("KR_6399807094")]
        public async Task GetMatchTimelineByMatchIdAsync(string matchId)
        {
            var result = await app.Match.GetMatchTimelineByMatchIdAsync(matchId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.info, Is.Not.Null);
        }

        [Test]
        public async Task GetFeaturedGamesAsync()
        {
            var result = await app.Spectator.GetFeaturedGamesAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.gameList, Is.Not.Empty);
        }

        [Test]
        public async Task GetStatusAsync()
        {
            var result = await app.Status.GetStatusAsync();
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(accountId)]
        public async Task GetSummonerByAccountIdAsync(string accountId)
        {
            var result = await app.Summoner.GetSummonerByAccountIdAsync(accountId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("베인인베인")]
        public async Task GetSummonerByNameAsync(string summonerName)
        {
            var result = await app.Summoner.GetSummonerByNameAsync(summonerName);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(puuId)]
        public async Task GetSummonerByPuuIdAsync(string puuId)
        {
            var result = await app.Summoner.GetSummonerByPuuIdAsync(puuId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(summonerId)]
        public async Task GetSummonerBySummonerIdAsync(string summonerId)
        {
            var result = await app.Summoner.GetSummonerBySummonerIdAsync(summonerId);
            Assert.That(result, Is.Not.Null);
        }
    }
}