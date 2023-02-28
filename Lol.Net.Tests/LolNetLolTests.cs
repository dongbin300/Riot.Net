using Lol.Net.Applications;

namespace Lol.Net.Tests
{
    public class LolNetLolTests
    {
        LolApplication app;

        [SetUp]
        public void Setup()
        {
            app = new LolApplication();
        }

        [Test]
        public async Task GetGameModesAsync()
        {
            var result = await app.GameConstants.GetGameModesAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetGameTypesAsync()
        {
            var result = await app.GameConstants.GetGameTypesAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetMapsAsync()
        {
            var result = await app.GameConstants.GetMapsAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetQueuesAsync()
        {
            var result = await app.GameConstants.GetQueuesAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetSeasonsAsync()
        {
            var result = await app.GameConstants.GetSeasonsAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }
    }
}