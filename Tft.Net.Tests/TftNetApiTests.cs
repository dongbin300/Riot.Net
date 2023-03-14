using Riot.Net;
using Riot.Net.Enums;

using Tft.Net.Clients;

namespace Tft.Net.Tests
{
    public class TftNetApiTests
    {
        TftClient app;

        [SetUp]
        public void Setup()
        {
            app = new TftClient(Configuration.DevelopmentApiKey, PlatformRouting.KR, RegionalRouting.ASIA);
        }

        [TestCase(Tier.DIAMOND, Division.IV)]
        [TestCase(Tier.PLATINUM, Division.IV)]
        public async Task GetAllLeagueEntriesAsync(Tier tier, Division division)
        {
            var result = await app.League.GetAllLeagueEntriesAsync(tier, division);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetChallengerLeagueAsync()
        {
            var result = await app.League.GetChallengerLeagueAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [Test]
        public async Task GetGrandMasterLeagueAsync()
        {
            var result = await app.League.GetGrandMasterLeagueAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [Test]
        public async Task GetMasterLeagueAsync()
        {
            var result = await app.League.GetMasterLeagueAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase(Queue.RankedTftTurbo)]
        public async Task GetTopRatedLadderAsync(Queue queue)
        {
            var result = await app.League.GetTopRatedLadderAsync(queue);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("bf18e0ba-d906-3a5f-a6f1-62b94453988b")]
        public async Task GetLeagueByLeagueIdAsync(string leagueId)
        {
            var result = await app.League.GetLeagueByLeagueIdAsync(leagueId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.entries, Is.Not.Empty);
        }

        [TestCase("k7hhkLFJ3TBVdjX7sqLlRd1w9ZlWn2kV4_XUQaOzU4-VpT3o693fA0Rosw")]
        public async Task GetLeagueEntriesBySummonerIdAsync(string summonerId)
        {
            var result = await app.League.GetLeagueEntriesBySummonerIdAsync(summonerId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("KR_6404590554")]
        public async Task GetMatchByMatchIdAsync(string matchId)
        {
            var result = await app.Match.GetMatchByMatchIdAsync(matchId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.info, Is.Not.Null);
        }

        [TestCase("9i-UVlmXF_xJlIhWlbqsOCLHxf40we_jhXgyjTtboLOs021VxTMCpMzJf29FFKMhpCXihKSBF_bSaA")]
        public async Task GetMatchIdsByPuuIdAsync(string puuId)
        {
            var result = await app.Match.GetMatchIdsByPuuIdAsync(puuId);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetStatusAsync()
        {
            var result = await app.Status.GetStatusAsync();
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("l0PLALAoYu3Fqca3ryc4OSVfjZtvqL87LTa7qCsOkiqQ")]
        public async Task GetSummonerByAccountIdAsync(string accountId)
        {
            var result = await app.Summoner.GetSummonerByAccountIdAsync(accountId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("a19FsvW0NOTC3jpT5f89oIz72RpcnNN5RvO_T3g16lRFoJV6ogYw8pB7puaxUYag8U0ACbxQVcMFeg")]
        public async Task GetSummonerByPuuIdAsync(string puuId)
        {
            var result = await app.Summoner.GetSummonerByPuuIdAsync(puuId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("CDrlNNDbATIphPaLUQGmZGzw6S2m0PHpcY6dhMZlMsav3HM")]
        public async Task GetSummonerBySummonerIdAsync(string summonerId)
        {
            var result = await app.Summoner.GetSummonerBySummonerIdAsync(summonerId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("플라인드")]
        public async Task GetSummonerBySummonerNameAsync(string summonerName)
        {
            var result = await app.Summoner.GetSummonerBySummonerNameAsync(summonerName);
            Assert.That(result, Is.Not.Null);
        }
    }
}