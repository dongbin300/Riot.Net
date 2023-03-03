using Lol.Net.Clients;
using Lol.Net.Enums;

namespace Lol.Net.Tests
{
    public class LolNetDataDragonTests
    {
        LolClient app;
        string version = "13.4.1";
        string scoreboardIconVersion = "5.5.1";
        LanguageEnum language = Language.English_UnitedStates;

        [SetUp]
        public void Setup()
        {
            app = new LolClient();
        }

        [Test]
        public async Task GetChampionsAsync()
        {
            var result = await app.DataDragon.Champions.GetChampionsAsync(version, language);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(Champion.Blitzcrank)]
        [TestCase(Champion.Thresh)]
        [TestCase(Champion.Kalista)]
        [TestCase(Champion.Vayne)]
        [TestCase(Champion.Amumu)]
        [TestCase(Champion.MasterYi)]
        public async Task GetChampionsAsync(Champion champion)
        {
            var result = await app.DataDragon.Champions.GetChampionDetailAsync(champion, version, language);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("VayneCondemn")]
        [TestCase("FlashFrost")]
        [TestCase("RocketGrab")]
        public async Task GetChampionAbilityAssetsAsync(string abilityName)
        {
            var result = await app.DataDragon.Champions.GetChampionAbilityAssetsAsync(abilityName, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(Champion.Vayne, 0)]
        [TestCase(Champion.Blitzcrank, 2)]
        [TestCase(Champion.Thresh, 3)]
        public async Task GetChampionSplashAssetsAsync(Champion champion, int skinNum)
        {
            var result = await app.DataDragon.Champions.GetChampionSplashAssetsAsync(champion, skinNum);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(Champion.Blitzcrank)]
        [TestCase(Champion.Thresh)]
        [TestCase(Champion.Kalista)]
        [TestCase(Champion.Vayne)]
        [TestCase(Champion.Amumu)]
        [TestCase(Champion.MasterYi)]
        public async Task GetChampionSquareAssetsAsync(Champion champion)
        {
            var result = await app.DataDragon.Champions.GetChampionSquareAssetsAsync(champion, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("Vayne_NightHunter")]
        [TestCase("Blitzcrank_ManaBarrier")]
        [TestCase("Thresh_Passive")]
        public async Task GetChampionPassiveAssetsAsync(string passiveImageName)
        {
            var result = await app.DataDragon.Champions.GetChampionPassiveAssetsAsync(passiveImageName, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase(Champion.Vayne, 0)]
        [TestCase(Champion.Blitzcrank, 2)]
        [TestCase(Champion.Thresh, 3)]
        public async Task GetChampionLoadingScreenAssetsAsync(Champion champion, int skinNum)
        {
            var result = await app.DataDragon.Champions.GetChampionLoadingScreenAssetsAsync(champion, skinNum);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetLanguagesAsync()
        {
            var result = await app.DataDragon.DataAndAssets.GetLanguagesAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetItemsAsync()
        {
            var result = await app.DataDragon.Items.GetItemsAsync(version, language);
            Assert.That(result, Is.Not.Null);
        }

        [TestCase("1028")]
        [TestCase("1510")]
        [TestCase("3083")]
        [TestCase("4638")]
        [TestCase("7013")]
        [TestCase("7028")]
        public async Task GetItemsAsync(string itemId)
        {
            var result = await app.DataDragon.Items.GetItemAssetsAsync(itemId, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("map11")]
        [TestCase("map12")]
        [TestCase("map21")]
        [TestCase("map22")]
        public async Task GetMinimapAssetsAsync(string mapName)
        {
            var result = await app.DataDragon.Other.GetMinimapAssetsAsync(mapName, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("1012")]
        [TestCase("1057")]
        [TestCase("1059")]
        [TestCase("3737")]
        [TestCase("977")]
        public async Task GetProfileIconAssetsAsync(string profileIconId)
        {
            var result = await app.DataDragon.Other.GetProfileIconAssetsAsync(profileIconId, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetProfileIconsAsync()
        {
            var result = await app.DataDragon.Other.GetProfileIconsAsync(version, language);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("champion")]
        [TestCase("items")]
        [TestCase("minion")]
        [TestCase("score")]
        [TestCase("spells")]
        public async Task GetScoreboardIconAssetsAsync(string name)
        {
            var result = await app.DataDragon.Other.GetScoreboardIconAssetsAsync(name, scoreboardIconVersion);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("spell0")]
        [TestCase("spell1")]
        public async Task GetSpriteAssetsAsync(string spellName)
        {
            var result = await app.DataDragon.Other.GetSpriteAssetsAsync(spellName, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [TestCase("SummonerTeleport")]
        [TestCase("SummonerHeal")]
        [TestCase("SummonerFlash")]
        public async Task GetSummonerSpellAssetsAsync(string spellId)
        {
            var result = await app.DataDragon.Other.GetSummonerSpellAssetsAsync(spellId, version);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public async Task GetSummonerSpellsAsync()
        {
            var result = await app.DataDragon.Other.GetSummonerSpellsAsync(version, language);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetRegionsAsync()
        {
            var result = await app.DataDragon.Regions.GetRegionsAsync();
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task GetVersionsAsync()
        {
            var result = await app.DataDragon.Versions.GetVersionsAsync();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
        }
    }
}