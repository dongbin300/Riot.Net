using Lor.Net.Clients;
using Lor.Net.Enums;

using Riot.Net.Enums;

namespace Lor.Net.Tests
{
    public class LorNetDataDragonTests
    {
        LorClient app;
        SetBundleTypeEnum setBundleType = SetBundleType.Set1_Lite;
        LanguageEnum language = Language.English_UnitedStates;

        [SetUp]
        public void Setup()
        {
            app = new LorClient();
        }

        [TestCase("01DE001")]
        [TestCase("01FR009T1")]
        [TestCase("01FR053")]
        public async Task GetCardImagesAsync(string cardId)
        {
            var result = await app.DataDragon.SetBundles.GetCardImagesAsync(setBundleType, language, cardId);
            Assert.That(result, Is.Not.Null);
        }
    }
}