using Riot.Net;

using Val.Net.Clients;
using Val.Net.Enums;

namespace Val.Net.Tests
{
    public class ValNetApiTests
    {
        ValClient app;

        [SetUp]
        public void Setup()
        {
            app = new ValClient(Configuration.DevelopmentApiKey, Enums.ValRegion.KR);
        }

        [TestCase("en-US")]
        [TestCase("ja-JP")]
        [TestCase("ko-KR")]
        public async Task GetContentOptionallyByLocaleAsync(string locale)
        {
            var result = await app.Content.GetContentOptionallyByLocaleAsync(locale);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.maps, Is.Not.Empty);
            Assert.That(result.equips, Is.Not.Empty);
            Assert.That(result.skins, Is.Not.Empty);
            Assert.That(result.acts, Is.Not.Empty);
            Assert.That(result.characters, Is.Not.Empty);
        }

        [TestCase("matchId1")]
        [TestCase("matchId2")]
        [TestCase("matchId3")]
        public async Task GetMatchByMatchIdAsync(string matchId)
        {
            var result = await app.Match.GetMatchByMatchIdAsync(matchId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("puuId1")]
        [TestCase("puuId2")]
        [TestCase("puuId3")]
        public async Task GetMatchlistByPuuIdAsync(string puuId)
        {
            var result = await app.Match.GetMatchlistByPuuIdAsync(puuId);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase(ValQueue.competitive)]
        [TestCase(ValQueue.deathmatch)]
        [TestCase(ValQueue.tournamentmode)]
        public async Task GetRecentMatchesAsync(ValQueue queue)
        {
            var result = await app.Match.GetRecentMatchesAsync(queue);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("actId1")]
        [TestCase("actId2", 10)]
        [TestCase("actId3", 50, 10)]
        public async Task GetLeaderboardAsync(string actId, int size = 200, int index = 0)
        {
            var result = await app.Ranked.GetLeaderboardAsync(actId, size, index);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetStatusAsync()
        {
            var result = await app.Status.GetStatusAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.locales, Is.Not.Empty);
        }
    }
}