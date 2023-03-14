using Lor.Net.Clients;

namespace Lor.Net.Tests
{
    public class LorNetGameClientTests
    {
        LorClient app;

        [SetUp]
        public void Setup()
        {
            app = new LorClient();
        }

        [Test]
        public async Task GetStaticDecklistAsync()
        {
            var result = await app.ActiveDeck.GetStaticDecklistAsync();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetPositionalRectanglesAsync()
        {
            var result = await app.CardPosition.GetPositionalRectanglesAsync();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetGameResultAsync()
        {
            var result = await app.GameResult.GetGameResultAsync();
            Assert.That(result, Is.Not.Null);
        }
    }
}